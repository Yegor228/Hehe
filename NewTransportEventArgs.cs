using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hehe
{
    public class NewTransportEventArgs : EventArgs
    {
        private readonly string t_type;
        private readonly string t_name;

        public NewTransportEventArgs(List<ITransport> tl, ITransport transport)
        {
            tl.Add(transport);
            this.t_type = transport.GetTypeTransport();
            this.t_name = transport.GetType().ToString();
        }

        public string Type { get { return t_type; } }
        public string Name { get { return t_name; } }

    }
}
