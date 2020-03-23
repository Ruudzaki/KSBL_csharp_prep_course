namespace KSBL_Class_Library.Components.SmsModule
{
    public class SmsProvider
    {
        public delegate string FormatDelegate(string text);

        public delegate void SmsRecievedDelegate(string message);

        public string LastText { get; set; }

        public FormatDelegate Formatter { get; set; }

        public event SmsRecievedDelegate SmsReceived;

        public void PrintMessage(object message)
        {
            LastText = OnSmsReceived((string) message);
        }

        private string OnSmsReceived(string message)
        {
            if (Formatter != null) message = Formatter($"{message}");

            var handler = SmsReceived;
            handler?.Invoke(message);

            return message;
        }
    }
}