using System;
using System.Collections.Generic;
using System.Linq;
using KSBL_Class_Library.Components.SmsModule;

namespace KSBL_Class_Library.Components.Storage
{
    public delegate Message FormatDelegate(Message message);

    public delegate void SmsAddedDelegate(Message message);

    public abstract class BasicStorage
    {
        private static readonly object Locker = new object();

        protected BasicStorage(int capacity)
        {
            Capacity = capacity;
            Messages = new List<Message>();
            UniqueUsers = new List<string>();
            Count = 0;
        }

        public FormatDelegate Formatter { get; set; }

        public List<Message> Messages { get; set; }
        private int Count { get; set; }
        public List<string> UniqueUsers { get; set; }

        public int Capacity { get; }
        public event SmsAddedDelegate SmsAdded;

        public abstract void LoadFromHardMemory(ILoadFromStorage loadFromHardMemory);
        public abstract void LoadToHardMemory(ILoadToStorage loadToHardMemory);


        //Adding
        public void AddMessage(object message)
        {
            lock (Locker)
            {
                message = ((Message) message).Clone();
                OnAddMessage((Message) message);
            }
        }

        public void OnAddMessage(Message message)
        {
            Messages.Add(message);
            Count++;

            Messages[Messages.Count - 1].ReferenceNumber = Count;
            message.FormatText = $"{message.Text} #{Messages[Messages.Count - 1].ReferenceNumber}";

            if (!UniqueUsers.Contains(message.User)) UniqueUsers.Add(message.User);

            var handler = SmsAdded;
            handler?.Invoke(Messages[Messages.Count - 1]);
        }

        //Removing
        public void RemoveMessage(object message)
        {
            lock (Locker)
            {
                OnRemoveMessage((Message) message);
            }
        }

        public void OnRemoveMessage(Message message)
        {
            var item = Messages.Find(x =>
                x.Text == message.Text && x.ReceivingTime == message.ReceivingTime && x.User == message.User);
            if (item != null)
                Messages.Remove(item);

            if (Messages.Count(t => t.User == message.User) == 1) UniqueUsers.Remove(message.User);
        }

        //Formatting
        public Message FormatText(Message message)
        {
            if (Formatter != null) Formatter(message);
            else
                message.FormatText = $"{message.Text} #{message.ReferenceNumber}";

            return message;
        }

        //Filtering
        public IEnumerable<Message> FilterByUser(IEnumerable<Message> messages, string user)
        {
            return !string.IsNullOrEmpty(user) ? messages.Where(t => t.User == user) : messages;
        }

        public IEnumerable<Message> FilterBySearchText(IEnumerable<Message> messages, string text)
        {
                return text != "" ? messages.Where(t => t.FormatText.Contains(text)) : messages;
        }

        public IEnumerable<Message> FilterByStartDate(IEnumerable<Message> messages, DateTime startDate)
        {
            return startDate != new DateTime() ? messages.Where(t => t.ReceivingTime >= startDate) : messages;
        }

        public IEnumerable<Message> FilterByEndDate(IEnumerable<Message> messages, DateTime endDate)
        {
            return endDate != new DateTime() ? messages.Where(t => t.ReceivingTime <= endDate) : messages;
        }

        public IEnumerable<Message> FilterAll(IEnumerable<Message> messages, string user, string text,
            DateTime startTime, DateTime endDate)
        {
            var selectedMessages = FilterByUser(messages, user);
            selectedMessages = FilterBySearchText(selectedMessages, text);
            selectedMessages = FilterByStartDate(selectedMessages, startTime);
            selectedMessages = FilterByEndDate(selectedMessages, endDate);

            selectedMessages = selectedMessages.OrderBy(t => t.ReferenceNumber);

            return selectedMessages;
        }

        public IEnumerable<Message> FilterByUnion(IEnumerable<Message> messages, string user, string text,
            DateTime startTime, DateTime endDate)
        {
            var selectedMessages = FilterByUser(messages, user);
            selectedMessages = selectedMessages.Union(FilterBySearchText(messages, text));
            selectedMessages = selectedMessages.Union(FilterByEndDate(FilterByStartDate(messages, startTime), endDate));

            selectedMessages = selectedMessages.OrderBy(t => t.ReferenceNumber);

            return selectedMessages;
        }
    }
}