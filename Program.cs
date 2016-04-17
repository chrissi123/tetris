using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent(3, "gsdgs");
            p.Druck();
            Console.WriteLine();
            p.I = 2;
            Console.WriteLine(p.I);
            Console.ReadLine();
        }
    }

    class Parent
    {
        int i;
        string s;

        public Parent(int i, string s)
        {
            this.i = i;
            this.s = s;
        }

        public int I
        {
            get { return i; }
            set { i = value; }
        }

        public void Druck()
        {
            Console.WriteLine("Ausgabe" + i + s);
            
        }

    }

}
