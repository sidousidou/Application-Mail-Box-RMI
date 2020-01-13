using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IRemote;

using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ClientReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChannelServices.RegisterChannel(new TcpClientChannel(), false);

                IFabrique fabrique = (IFabrique)Activator.GetObject(typeof(IFabrique), "tcp://localhost:9999/IFabrique");
                IMailBox mailBox = fabrique.CreateMail();

                //IMailBox mailBox = (IMailBox)Activator.GetObject(typeof(IMailBox),"tcp://localhost:9999/IMailBox");


                Console.WriteLine("Running!");

                List<Message> messages = mailBox.RecieveMsg();
                foreach (Message m in messages)
                {
                    Console.WriteLine("Name: " + m.name);
                    Console.WriteLine("Message: " + m.content);
                    Console.WriteLine("======================");
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Can't connect to server!");
            }
        }
    }
}
