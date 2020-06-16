using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingPrac
{
    class Program
    {
        class Parent
        {
            public int variable = 273;

            public void Method()
            {
                Console.WriteLine("Parent!");
            }
        }
        class Child : Parent
        {
            public string variable = "shadowing";
            public void Method()
            {
                Console.WriteLine("Child!");
            }
        }

        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine("variable : " + c.variable);
            Console.WriteLine("Parent variable : " + ((Parent)c).variable);

            c.Method();
            ((Parent)c).Method();
        }
    }
}
