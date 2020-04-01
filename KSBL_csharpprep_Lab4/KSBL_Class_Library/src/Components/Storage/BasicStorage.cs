using System.Collections.Generic;
using KSBL_Class_Library.Components.SmsModule;

namespace KSBL_Class_Library.Components.Storage
{
    public delegate Message FormatDelegate(Message message);

    public delegate void SmsAddedDelegate(Message message);

    public abstract class BasicStorage
    {
        private static readonly object _locker = new object();

        protected BasicStorage(int capacity)
        {
            Capacity = capacity;
            Messages = new List<Message>();
            Count = 0;
        }

        public FormatDelegate Formatter { get; set; }

        public List<Message> Messages { get; set; }
        private int Count { get; set; }

        public int Capacity { get; }
        public event SmsAddedDelegate SmsAdded;

        public abstract void LoadFromHardMemory(ILoadFromStorage loadFromHardMemory);
        public abstract void LoadToHardMemory(ILoadToStorage loadToHardMemory);

        public void AddMessage(object message)
        {
            lock (_locker)
            {
                message = (Message) message;
                message = ((Message) message).Clone();
                OnAddMessage((Message) message);
            }
        }

        public void OnAddMessage(Message message)
        {
            //Message newMessage = new Message(message.User, message.Text, message.ReceivingTime);
            //Message newMessage = (Message) message.Clone();

            Messages.Add(message);
            Count++;

            Messages[Messages.Count - 1].ReferenceNumber = Count;


            var handler = SmsAdded;
            handler?.Invoke(Messages[Messages.Count - 1]);
        }

        public Message FormatText(Message message)
        {
            if (Formatter != null) Formatter(message);
            else
                message.FormatText = $"{message.Text} #{message.ReferenceNumber}";

            return message;
        }
    }
}