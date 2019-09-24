using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class StringFunctions
    {
        public static void Main1(String[] args)
        {
            string mainString = File.ReadAllText(@"D:\\temp.txt");
            var splitString = mainString.ToCharArray();
            var dist = splitString.Distinct().ToList().OrderBy(c=>c);
            int count = 0;
            foreach (var aaa in dist)
            {
                count = 0;
                foreach (var aa in mainString)
                {
                    if (aaa == aa)
                    {
                        count++;
                    }
                }
                Console.WriteLine(aaa + "=" + count);
            }
             


            Console.ReadLine();

        }
        
    }
}
