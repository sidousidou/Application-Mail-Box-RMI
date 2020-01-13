using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemote;

namespace Server
{
    public class MailBox : MarshalByRefObject, IMailBox
    {
        public static List<Message> messages = new List<Message>();

        public List<Message> RecieveMsg()
        {
            return messages;
        }


        public void SendMsg(Message msg)
        {
            messages.Add(msg);
        }
    }
}
