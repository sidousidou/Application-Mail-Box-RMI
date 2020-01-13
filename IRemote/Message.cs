using System;
using System.Collections.Generic;
using System.Text;

namespace IRemote
{

    [Serializable]
    public class Message
    {
        public string name
        {
            get;
            set;
        }

        public string content
        {
            get;
            set;
        }

        public Message(string Name, string Content)
        {
            name = Name;
            content = Content;
        }
    }
}
