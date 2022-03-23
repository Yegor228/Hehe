using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hehe
{
    internal class Subj1
    {
        public Subj1(TransportManager tm)
        {
            tm.NewTransport += NewTransportMsg;
        }

        private void NewTransportMsg(Object sender, NewTransportEventArgs e)
        {
            Console.WriteLine("Transport added");
            Console.WriteLine(" Type = {0}, Name = {1}", e.Type, e.Name);
        }

        public void Unregister(TransportManager tm)
        {
            tm.NewTransport -= NewTransportMsg;
        }
    }
}
