using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class  PrivateConstructor
    {

        private PrivateConstructor()
        {
            c = 10;
            Console.WriteLine("Private Constructor");
        }
        public PrivateConstructor(int a)
        {

        }
        public static int a = 0;
        public static int b = 10;
        public int c = 20;
        public void getDate()
        {
            Console.WriteLine("Base");
        }
    }

    public class child 
    {
        PrivateConstructor obji = new PrivateConstructor(10);
        public child()
        {
            obji.getDate();
        }
    }

    public class mainClass
    {
        static void Main3(string[] args)
        {
            PrivateConstructor obj = new PrivateConstructor(10); // throws error inaccessible due to protection level

            PrivateConstructor.a = 10;
            
        }
    }

    
}
