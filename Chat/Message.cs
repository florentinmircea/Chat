using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Message
    {
        public string timestamp { get; set; }
        public string messageType { get; set; }
        public string message { get; set; }
        public string mediaUrl { get; set; }
        public string sender { get; set; }
    }
}
