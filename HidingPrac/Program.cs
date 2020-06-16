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
            public virtual void Method2()
            {
                Console.WriteLine("Parent!");
            }
        }
        class Child : Parent
        {
            public new string variable = "shadowing";
            public new void Method()
            {
                Console.WriteLine("Child!");
            }

            public override void Method2()
            {
                Console.WriteLine("Child!");
            }
        }

        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine("하이딩");
            Console.WriteLine("variable : " + c.variable);
            Console.WriteLine("Parent variable : " + ((Parent)c).variable);

            c.Method(); // 부모의 메서드를 가림. (부모의 메서드 남아있음)
            ((Parent)c).Method();

            Console.WriteLine("오버라이딩");
            c.Method2(); // 부모의 메서드를 덮어씀. (부모의 메서드 사라짐)
            ((Parent)c).Method2();  
        }
    }
}
