using System;
using System.Collections.Generic;
using System.Linq;

namespace Hehe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //TestTransport();


        }


        static void TestTransport()
        {
            TransportManager tm = new TransportManager();
            Subj1 subj = new Subj1(tm);
            Subj1 sbj = new Subj1(tm);

            Car car = new Car();
            Ship ship = new Ship();
            Airplane airplane = new Airplane();


            List<ITransport> transports = new List<ITransport>();
            tm.AddNewTransport(transports, car);
            tm.AddNewTransport(transports, ship);
            tm.AddNewTransport(transports, airplane);
        }

      
    }

    public abstract class Base
    {
        public Base(int i)
        { }
        public Base(int? i) 
        { 
            if(i == null)
                throw new ArgumentNullException(nameof(i));
        }
    }

    public class Foo : Base
    {
        //public Foo(string str) : base((str != null)?str.Length:throw new ArgumentNullException(nameof(str))){ }

        //public Foo(string str) : base(s?.Length ?? throw new ArgumentNullException(nameof(s))){ }
        public Foo(string str) : base(CheckNull(str)) { }

        static int CheckNull(string len)
        {
            if (len == null)
                throw new ArgumentNullException(nameof(len));
            return len.Length;
        }
    }

}
