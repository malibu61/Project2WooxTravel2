using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Project2WooxTravel2.Entities
{
    public class Message
    {

        public int MessageId { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
        public int AdminId{ get; set; }
        public virtual Admin Admin { get; set; }
    }
}