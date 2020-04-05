namespace KSBL_Class_Library.Components.SmsModule
{
    internal class SmsProvider
    {
        public delegate void SmsReceivedDelegate(Message message);

        private static readonly object Locker = new object();

        public static int Count { get; set; }

        public event SmsReceivedDelegate SmsReceived;

        public void PrintMessage(object message)
        {
            lock (Locker)
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