using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ClassAndObject
    {
        static void Main(string[] args)
        {
            Base obj = new Base();
            obj.display();
            obj.putData();

            child1 obj1 = new child1();
            obj1.display();
            obj1.putData();

            Base obj2 = new child1();
            obj2.display();
            obj2.putData();


        }
    }

    interface BaseInterface
    {
        void display();
    }
    class Base
    {
        public void display()
        {
            Console.WriteLine("Base class");
        }

        public virtual void putData()
        {
            Console.WriteLine("Put Base");
        }

        public new void PutData()
        {
            Console.WriteLine("Put child using new");
        }

    }

    class child1:Base
    {
        public void display()
        {
            Console.WriteLine("Child");
        }

        public override void putData()
        {
            Console.WriteLine("Put child");
        }

        

    }
}
