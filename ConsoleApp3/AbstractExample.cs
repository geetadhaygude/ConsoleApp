using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class AbstractExample
    {
        static void Main3(string[] args)
        {
            AbstractClass objAbstract = new ConcreteAbstractClass();
            objAbstract.Call();
            objAbstract.getData();
            //objAbstract.putData();  //unable to access due to instance variable
            objAbstract.displayData(); 

            ConcreteAbstractClass objCOncrete = new ConcreteAbstractClass();
            objCOncrete.putData();
            objCOncrete.displayData();

            AbstractClass objVirtual = new ConcreteVirtualClass();
            objVirtual.Call();
            objVirtual.displayData();


            Console.ReadLine();
        }
    }

    abstract class AbstractClass
    {
        int a = 10;
        public void getData()
        {
            Console.WriteLine("Abstract base class method called"+a);
        }

        public virtual void displayData()
        {
            Console.WriteLine("Base data");
        }
        public abstract void Call();
        
    }

     class ConcreteAbstractClass : AbstractClass
     {
        public override void  Call()
        {
            Console.WriteLine("COncrete method call in child class");
        }

        public  void putData()
        {
            Console.WriteLine("child class method called");
        }

     }

    class ConcreteVirtualClass : AbstractClass
    {
        public override void Call()
        {
            Console.WriteLine("Another virtual concrete class");
        }

        public override void displayData()
        {
            Console.WriteLine("child override method called");
        }
    }
}
