using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemote;

namespace Server
{
    public class Fabrique : MarshalByRefObject, IFabrique
    {
        public IMailBox CreateMail()
        {
            return new MailBox();
        }
    }
}
