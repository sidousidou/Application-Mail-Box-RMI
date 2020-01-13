using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemote;

namespace Fabrique
{
    public class Fabrique : MarshalByRefObject, IFabrique
    {
        public IMailBox CreateMail()
        {
            throw new NotImplementedException();
        }
    }
}
