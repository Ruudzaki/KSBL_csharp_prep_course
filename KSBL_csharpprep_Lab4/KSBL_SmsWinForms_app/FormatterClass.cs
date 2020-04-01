using KSBL_Class_Library.Components.SmsModule;

namespace KSBL_SmsWinForms_app
{
    //public delegate Message FormatDelegate(Message message);

    public class FormatterClass
    {
        //Format Methods to delegate
        public static Message FormatNone(Message message)
        {
            message.FormatText = $"{message.Text} #{message.ReferenceNumber}";
            return message;
        }

        public static Message FormatStartWithDate(Message message)
        {
            message.FormatText = $"[{message.ReceivingTime}] {message.Text} #{message.ReferenceNumber}";
            return message;
        }

        public static Message FormatEndWithDate(Message message)
        {
            message.FormatText = $"{message.Text} [{message.ReceivingTime}] #{message.ReferenceNumber}";
            return message;
        }

        public static Message FormatUpperCase(Message message)
        {
            message.FormatText = message.Text.ToUpper() + " #" + message.ReferenceNumber;
            return message;
        }

        public static Message FormatLowerCase(Message message)
        {
            message.FormatText = message.Text.ToLower() + " #" + message.ReferenceNumber;
            return message;
        }

        public static Message FormatUpperStartWithDate(Message message)
        {
            message.FormatText = $"[{message.ReceivingTime}] {message.Text.ToUpper()} #{message.ReferenceNumber}";
            return message;
        }
    }
}