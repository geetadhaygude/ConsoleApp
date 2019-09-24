using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main1(string[] args)
        {
            //    Test a = new Test();
            //    int b=a.show(1,1);
            //    float f = a.show(1.0f, 1.0f);
            //Test2 obj = new Test2();
            //    int a=obj.show(1,2);
            //    Console.WriteLine(a);
            //    Test obj1 = new Test();
            //    int b=obj1.show(1, 1);

            //a1 c = new c1();
            //int a=c.t1();
            //a2 d = new c1();
            //int b=d.t1();
            //int b = 0;
            //try
            //{
            //    double a = 1 / b;

            //}
            //catch (DivideByZeroException ar)
            //{

            //}
            //catch (Exception a)
            //{

            //}

            //finally
            //{
            //    //return b;
            //}

            //Test obj = new Test();
            //int j=obj.show(12,13);
            //Test2 obj1 = new Test2();
            //int i=obj1.show(10,10);

            //CustomerBusinessLogic objnew = new CustomerBusinessLogic();
            //objnew.GetCustomerName(1);

            var a = "abs";
            a = "abc"+50;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }

    public class Test
    {
        public virtual int show(int a, int j) {
            return 0;
        }

        public void im()
        {

        }

    }

    class Test2 : Test
    {
        public override int show(int a, int b)
        {
            return 1;
        }
    }

    interface a1
    {

        int t1();
    }
    interface a2
    {
        int t1();
    }

    public class c1 : a1, a2
    {
        int a1.t1()
        {
            return 1;
        }
        int a2.t1()
        {
            return 2;
        }
    }

    public static class temp2{
        static int a = 0;
        static void tempp() { }
    }

    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }

    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess; 

        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
}
