using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class StackDemo
    {
        static void Main66(string[] args)
        { 

            Queue objQueue = new Queue();
            objQueue.Enqueue("One");
            objQueue.Enqueue("Two");
            objQueue.Enqueue("Three");

            foreach(var obj in objQueue)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Deleted Element: " + objQueue.Dequeue());
            Console.WriteLine("After Delete");
            foreach (var obj in objQueue)
            {
                Console.WriteLine(obj);
            }
            Stack objStack = new Stack();
            objStack.Push("One");
            objStack.Push("Two");
            objStack.Push("Three");
            objStack.Push("Four");
            objStack.Push("Five");

            foreach (var item in objStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count of Stack:" + objStack.Count);

            Console.WriteLine(objStack.Pop());
            Console.WriteLine("After Deleted");
            foreach (var item in objStack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
            
    }
}
