using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hehe
{
    internal class TransportManager
    {

        public event EventHandler<NewTransportEventArgs> NewTransport;
  
        protected void OnNewTransport(NewTransportEventArgs e)
        {
            EventHandler<NewTransportEventArgs> temp = NewTransport;
            if(temp != null) temp(this, e);
        }

        public void AddNewTransport(List<ITransport> tl, ITransport transport)
        {
            tl.Add(transport);
            NewTransportEventArgs e = new NewTransportEventArgs(tl, transport);
            OnNewTransport(e);
        }
    }
}
