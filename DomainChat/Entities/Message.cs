using System;
using System.Collections.Generic;
using System.Text;

namespace DomainChat.Entities
{
    public class Message
    {
        public string  Sender { get; set; }
        public string Receiver { get; set; }
        public  DateTime MessageDate { get; set; }
        public string Content { get; set; }
        public bool IsNew { get; set; } = false;
        public bool IsSenderDelete { get; set; } = false;
        public bool IsReceiverDeleted { get; set; } = false;
    }
}
