using System;

namespace KSBL_Class_Library.Components.SmsModule
{
    public class Message : ICloneable
    {
        public Message(string user, string text, DateTime receivingTime)
        {
            User = user;
            Text = text;
            ReceivingTime = receivingTime;
        }

        public string User { get; set; }

        public string Text { get; set; }

        public string FormatText { get; set; }

        public int ReferenceNumber { get; set; }

        public DateTime ReceivingTime { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}