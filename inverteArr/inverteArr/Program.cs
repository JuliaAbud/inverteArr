using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverteArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = new int[] { 10, 9, 8, 7, 6, 5 };
            int[] auxArr = new int[mainArr.Length];

            for (int i = mainArr.Length - 1; i >= 0; i--)
            {
                auxArr[mainArr.Length - 1 - i] = mainArr[i];
                
            }
            foreach (int item in auxArr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
