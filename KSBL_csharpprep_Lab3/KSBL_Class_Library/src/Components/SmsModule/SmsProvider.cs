using System;
using System.Threading;


namespace KSBL_Class_Library.Components.SmsModule
{

    public class SmsProvider
    {

        public delegate void SmsRecievedDelegate(string message);
        public delegate string FormatDelegate(string text);

        private readonly FormatDelegate Formatter = new FormatDelegate(FormatWithTime);
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
            if (Output != null)
                Output.WriteLine((string)$"{message}");
        }

        private void OnSmsReceived(string message)
        {

            var handler = SmsReceived;
            handler?.Invoke(message);
        }

        private static string FormatWithTime(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }
    }
}