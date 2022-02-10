using System;
using System.Collections.Generic;
using System.Linq;

namespace Hehe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TestThisClass();
            CheckTestRefInOut();

            TestTransport();

            //Test init и get
            //Atr a = new Atr(10);
            //Console.WriteLine(a.Test + " " + a.TestInit);

            string str = null;
            var f = new Foo(str); 
                
        }

        static void TestTransport()
        {
            Car car = new Car();
            Ship ship = new Ship();
            Airplane airplane = new Airplane();

            List<ITransport> transports = new List<ITransport>();
            transports.Add(car);
            transports.Add(ship);
            transports.Add(airplane);
            foreach (var tr in transports)
            {
                tr.GetTypeTransport();
                tr.Movement();
            }
        }

        static void CheckTestRefInOut()
        {
            string a = "", b = "", c = "Book";
 
            TestRefInOut(ref a, out b, c);
            Console.WriteLine(a + "\n" + b + "\n" + c);
        }

        static void TestRefInOut(ref string refString, out string outString, in string inString)
        {
            refString += "refModified";
            outString = "outModified"; // Обязательно необходимо изменить!
            //inString = "InModified";  readonly
        }
        
        static void TestThisClass()
        {
            TestClass tc = new TestClass();
            for (int i = 0; i < tc.Length; i++)
            {
                Console.WriteLine(tc[i]);
            }
        }
    }

    public class TestClass
    {
        public string[] Ttr = new string[] {"Winter", "Spring", "Summer", "Autumn" };

        public int Length => Ttr.Length;

        public string this[int index]
        {
            get{ return Ttr[index]; }
            set{ Ttr[index] = value; }
        }
    }

    public class Atr
    {
        public int Test { get; } = 20;

        public int TestInit { get;  init; }

        public Atr(int tmp)
        {
            TestInit = tmp;
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
