using System;
using System.Threading;


namespace KSBL_Class_Library.Components.SmsModule
{

    public class SmsProvider
    {

        public delegate void SmsRecievedDelegate(string message);
        public delegate string FormatDelegate(string text);

        public FormatDelegate Formatter { get; set; }
        public event SmsRecievedDelegate SmsReceived;
        public IOutput Output { get; }

        public SmsProvider(IOutput output, string message)
        {
            Output = output;
            //TimerCallback tm = PrintMessage;

            //var timer = new Timer(tm, message, 0, 2000);
        }

        public void PrintMessage(object message)
        {
            OnSmsReceived((string)message);
        }

        private void OnSmsReceived(string message)
        {
            if (Formatter != null)
            {
                message = Formatter($"{message}");
            }
            var handler = SmsReceived;
            handler?.Invoke(message);
        }

        private static string FormatStartWithDate(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }

        private static string FormatEndWithDate(string message)
        {
            return $"{message} [{DateTime.Now}]";
        }
    }
}