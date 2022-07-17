using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Service.SenderService
{
    public class Message : IMessage
    {
        public void SendMessage(ISender sender)
        {
            sender.Send();
        }
    }
}
