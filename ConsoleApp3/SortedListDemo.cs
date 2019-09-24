using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SortedListDemo
    {
        static void Main55(string[] args)
        {

            SortedList objSortedList = new SortedList();
            objSortedList.Add(1, "one");
            objSortedList.Add(2, "two");

            foreach(DictionaryEntry sort in objSortedList)
            {
                Console.WriteLine(sort.Key+"_"+sort.Value);
            }
            //Console.ReadLine();
            Console.WriteLine("Hashtable");
            Hashtable objHash = new Hashtable()
            {
                {1,"Three" },
                {2,"Four" },
                {3,"Five" },
            };
            foreach(var i in objHash.Keys)
            {
                Console.WriteLine("Key:" + i + "_" + objHash[i]);
            }
            Console.ReadLine();
        }
    }
}
