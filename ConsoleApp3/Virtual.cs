using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Virtual
    {
        static void Main2(String[] args)
        {
            childClass objChild = new childClass();
            objChild.getData();

            baseClass objBase = new baseClass();
            objBase.getData();
            Console.ReadLine();
        }
    }
    public  class baseClass
    {
        public virtual void getData()
        {
            Console.WriteLine("base class method");
        }
    }
    public class childClass : baseClass
    {
        public override void getData()
        {
            Console.WriteLine("child class method");
        }
    }

    public abstract class abstractExample
    {
        public virtual void baseMethod()
        {
            Console.WriteLine("not override");
        }

        public abstract void overrideMethod();
        
    }

    public class AbstractDerivedClass : abstractExample
    {
        public override void overrideMethod()
        {

        }

        public override void baseMethod()
        {
            
        }
    }

    interface testInterface
    {
        void testData();
    }

    public class testClass : testInterface
    {
        public void testData() { 

        }
    }
}
