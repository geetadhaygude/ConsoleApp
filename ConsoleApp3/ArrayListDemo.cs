using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ArrayListDemo
    {
        static void Main44(string[] args)
        {
            ArrayList objArrayList = new ArrayList();
                        
            objArrayList.Add(1);
            objArrayList.Add("two");
            objArrayList.Add(3.5);
            foreach(var o in objArrayList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Next List");
            IList objList = new ArrayList()
            {
                100,200,"Three",4.5
            };
            

            Console.WriteLine("Club List");
            objArrayList.AddRange(objList);
            foreach(var ol in objArrayList) {
                Console.WriteLine(ol);
            }


            Console.WriteLine("Accessing Elements:");
            Console.WriteLine("First Element: "+objArrayList[2]);
            Console.WriteLine("Insert Elements:");
            objArrayList.Insert(3, "Hello");
            foreach (var o in objArrayList)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
        }
    }
}
