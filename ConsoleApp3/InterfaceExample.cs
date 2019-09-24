using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class InterfaceExample
    {
        static void Main11(string[] args)
        {
            //Scenario 1
            ConcreteClass objConcrete = new ConcreteClass();
            objConcrete.getData();
            objConcrete.call();

            //Scenario 2
            ExampleInterface objAnother = new AnotherConcreteClass();
            objAnother.call();

            //Scenario 3
            ExampleInterface objInterface1 = new MultipleIneritance();
            objInterface1.call();

            ExampleInterface2 objInterface2 = new MultipleIneritance();
            objInterface2.call();

            Console.ReadLine();
        }

        
    }

   interface ExampleInterface
    {
        //int val = 10; throws error
        void call();
        
    }

    interface ExampleInterface2
    {
        void call();
    }

     class ConcreteClass : InterfaceExample
    {
       public void call()
        {
            Console.WriteLine("interface method called");
        }

        public void getData()
        {
            Console.WriteLine("class method called");
        }
    }

    public class AnotherConcreteClass : ExampleInterface
    {
        public void call()
        {
            Console.WriteLine("Concrete method called");
        }
    }

    class MultipleIneritance : ExampleInterface, ExampleInterface2
    {
        void ExampleInterface.call()
        {
            Console.WriteLine("ExampleInterface method called");
        }

        void ExampleInterface2.call()
        {
            Console.WriteLine("ExampleInterface2 method called");
        }

    }
}
