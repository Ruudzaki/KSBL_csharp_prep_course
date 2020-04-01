using System;
using System.Collections.Generic;
using System.Linq;

namespace KSBL_Class_Library.Components.SmsModule
{
    public class SmsProvider
    {
        private static object _locker = new object();

        public delegate Message FormatDelegate(Message message);

        public delegate void SmsRecievedDelegate(Message message);

        public List<Message> Messages { get; set; }

        public string LastText { get; set; }

        public static int Count { get; set; }

        public FormatDelegate Formatter { get; set; }

        public event SmsRecievedDelegate SmsReceived;

        public void PrintMessage(object message)
        {
            lock (_locker)
            {
                LastText = OnSmsReceived((Message) message);
            }
        }

        private string OnSmsReceived(Message message)
        {
            message.ReferenceNumber = ++Count;
            if (Formatter != null) message = Formatter(message);
            else
            {
                message.FormatText = $"{message.Text} #{message.ReferenceNumber}";
            }

            Messages.Add(message);

            var handler = SmsReceived;
            handler?.Invoke(message);


            return message.FormatText;
        }

        public SmsProvider()
        {
            Messages = new List<Message>();
            Count = 0;
        }
    }
}