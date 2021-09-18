using System;
using System.Collections.Generic;
using System.Text;

namespace IRemote
{
    public interface IFabrique
    {
        IMailBox CreateMail();
    }
}
