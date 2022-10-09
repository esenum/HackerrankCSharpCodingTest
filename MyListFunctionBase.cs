using System.Collections.Generic;
using System;

namespace HackerrankCSharpCodingTest
{
    public static class MyListFunctionBase
    {
        public static void MySortFunction(this List<int> li)
        {
            int temp;
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }

                }

                Console.WriteLine(".......................");
                foreach (var item in li)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(".......................");
            }

        }
    }
}