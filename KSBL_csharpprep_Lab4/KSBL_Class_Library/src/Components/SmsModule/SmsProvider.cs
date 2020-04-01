namespace KSBL_Class_Library.Components.SmsModule
{
    internal class SmsProvider
    {
        public delegate void SmsRecievedDelegate(Message message);

        private static readonly object _locker = new object();

        public static int Count { get; set; }

        public event SmsRecievedDelegate SmsReceived;

        public void PrintMessage(object message)
        {
            lock (_locker)
            {
                OnSmsReceived((Message) message);
            }
        }

        private void OnSmsReceived(Message message)
        {
            var handler = SmsReceived;
            handler?.Invoke(message);
        }
    }
}