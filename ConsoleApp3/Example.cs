using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Example
    {
        static void Main22(string[] args)
        {
            //int k = //(6)(8)
            //int j = Check(2, 4, 5);(4,4)(5,5)(4,5)(4)(5)
            //int m = Check(3, 5, 7);(5,5,5)(7,7,7)(5,5,7)(5,7,7)
            //(5,5,5,5)(7,7,7,7)(5,7,7,7)(5,5,7,7)(5,5,5,7)
            Console.WriteLine(Check(5, 6, 6));
            Console.ReadLine();
        }

        static int Check(int no, int a,int b)
        {
            int count = 0;
            if (a < b )
            {
                count = 2;
                for (int i = no; i > 1; i--)
                {
                    count = (i+1) + count;
                }
                return count;
            }
            else if(a==b)
            {
                return count=1;
            }
            return count;
        } 
    }

    
}
