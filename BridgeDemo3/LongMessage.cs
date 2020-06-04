using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo3
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSendor)
        {
            this.messageSender = messageSendor;
        }
        public override void SendMessage(string Message)
        {
            messageSender.SendMessage(Message);
        }
    }
}
