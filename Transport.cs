using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hehe
{

    interface ITransport
    {
        void GetTypeTransport();

        abstract void Movement();
    }

    abstract public class Transport : ITransport
    {
        public abstract void Movement();

        public void GetTypeTransport()
        {
            Console.WriteLine(GetType());
        }
    }

    public class Car : Transport
    {
        public override void Movement()
        {
            Console.WriteLine("CAR - DRIVE");
        }
    }

    public class Ship : Transport
    {
        public override void Movement()
        {
            Console.WriteLine("SHIP - DRIVE");
        }
    }

    public class Airplane: Transport
    {
        public override void Movement()
        {
            Console.WriteLine("AIRPLANE - FLY");
        }
    }
}
