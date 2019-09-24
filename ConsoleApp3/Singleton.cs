using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class SingletonExample
    {
        static void Main11(String[] args)
        {
            Singleton fromTeachaer = Singleton.getInstance;
            fromTeachaer.printDetails("From Teacher");
            Singleton fromStudent = Singleton.getInstance;
            fromStudent.printDetails("From Student");
            
            Console.ReadLine();
        }
    }

    class ThreadSafeSingletonExample
    {
        static void Main22(String[] args)
        {
            Parallel.Invoke(
                () => { PrintTeacherData(); },
                () => { PrintStudentData(); }
                );
            Console.ReadLine();
        }

        public static void PrintTeacherData()
        {
            ThreadSafeSingleton obj = ThreadSafeSingleton.getInstance;
            obj.PrintData("Teacher Data");
        }

        public static void PrintStudentData()
        {
            ThreadSafeSingleton obj = ThreadSafeSingleton.getInstance;
            obj.PrintData("Student Data");
        }


    }
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton getInstance{
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("count:" + counter);
        }

        public void printDetails(string message)
        {
            Console.WriteLine(message);
        }
        

    }

    public sealed class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static ThreadSafeSingleton instance = null;

        private static readonly Object objInstance = new object();
        public static ThreadSafeSingleton getInstance
        {
            get
            {
                lock (objInstance)
                {
                    if (instance == null)
                        instance = new ThreadSafeSingleton();
                    return instance;
                }
            }
        }
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter:" + counter);
        }

        public void PrintData(string message)
        {
            Console.WriteLine(message);
        }

    }

   


    
}
