using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class polymorphism
    {
        static void Main1(string[] args)
        {
            int x=10;
            //try
            //{
                
                
            //    BaseClassTest objBase = new BaseClassTest();
            //    objBase.baseMethod(ref x);
            //}
            //finally{
            //    Console.WriteLine("Executed");
            //}
            ChildClass objChild = new ChildClass();
            objChild.baseMethod(ref x);
            objChild.PutData();

            BaseClassTest objBase1 = new ChildClass();
            objBase1.baseMethod(ref x);
            objBase1.PutData();
            T1 obj = new T2();
            obj.getData();

            ChildInterface obj11 = new T2();
            obj11.getData();
            Console.ReadLine();
        }
    }

    class BaseClassTest
    {
        public virtual void baseMethod(ref int x)
        {
            Console.WriteLine("Base method"+x);
        }

        public void PutData()
        {
            Console.WriteLine("Basic");
        }

    }

    class ChildClass: BaseClassTest
    {
        public override void baseMethod(ref int a)
        {
            Console.WriteLine("Child Method");
        }

        public new void PutData()
        {
            Console.WriteLine("Basic");
        }

    }

    public interface T1
    {
        int a { get; set; }
         void getData();
    }

    public class ChildInterface
    {
        public void getData()
        {
            Console.WriteLine("Test");
        }
    }

    class T2 : ChildInterface, T1
    {
        public int a { get; set; }
        //public void getData()
        //{
        //    Console.WriteLine("Base");
        //}
        //}

        public new void getData()
        {
            Console.WriteLine("1");
        }
    }

}
