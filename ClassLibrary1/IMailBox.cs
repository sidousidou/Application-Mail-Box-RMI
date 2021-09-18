using System;
using System.Collections.Generic;
using System.Text;

namespace IRemote
{
    public interface IMailBox
    {
        void SendMsg(Message msg);
        List<Message> RecieveMsg();
        
    }
}
