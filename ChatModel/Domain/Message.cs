using System;

namespace ChatModel
{
    public class Message
    {
        public string Body { get; set; }
        public string SenderName { get; set; }
        public ChatRoom Room { get; set; }
        public DateTime DateSent { get; set; }
    }
}