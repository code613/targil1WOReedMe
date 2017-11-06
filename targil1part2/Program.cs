using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil1part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 5 sets of 5 numbers");
            int[,] grid = new int[5, 5];
            string theNumbers = (Console.ReadLine());
            string[] numArray = theNumbers.Split(new char[] { ' ', '\n', ',' });
            int[] myInts = Array.ConvertAll(numArray,Int32,);
            int maxg = Convert.ToInt16(numArray[0]);
            int ming = Convert.ToInt16(numArray[1]);
        }
    }
}
