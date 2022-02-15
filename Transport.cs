using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hehe
{

    public interface ITransport
    {
        string GetTypeTransport();

        abstract string Movement();
    }

    abstract public class Transport : ITransport
    {
        public abstract string Movement();

        public string GetTypeTransport()
        {
            return GetType().ToString();
        }
    }

    public class Car : Transport
    {
        public override string Movement()
        {
            return "CAR - DRIVE";
        }
    }

    public class Ship : Transport
    {
        public override string Movement()
        {
            return "SHIP - DRIVE";
        }
    }

    public class Airplane: Transport
    {
        public override string Movement()
        {
            return "AIRPLANE - FLY";
        }
    }
}
