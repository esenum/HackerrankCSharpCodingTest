using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharpCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> li=new List<int>();
            li.Add(1);
            li.Add(4);
            li.Add(3);
            li.Add(2);
            foreach(var item in li)
            {
                Console.WriteLine(item);
            }
            li.MySortFunction();
            Console.WriteLine("After sorting");
            foreach(var item in li)
            {
                Console.WriteLine(item);
            }

        }

        
    }
}
