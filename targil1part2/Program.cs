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
            Console.WriteLine("enter 5 sets of 5 numbers");
            int[,] numbers = new int[5, 5];
            string theNumbers = (Console.ReadLine());
            string[] numArray = theNumbers.Split(new char[] { ' ', '\n', ',' });
            for (var i = 0; i < 5; i++)
            {
                //var numList = new string[5];
                // numList = readLine.Split();
                //added this
                for (var j = 0; j < 5; j++)
                {
                    numbers[i, j] = Convert.ToInt32(numArray[i * 5 + j]);
                }
            }
            //string[] numArray = theNumbers.Split(new char[] { ' ', '\n', ',' });
            //int[] myInts = Array.ConvertAll(numArray,Int32,);
            ////ok now adding this to change the document
            //int maxg = Convert.ToInt16(numArray[0]);
            //int ming = Convert.ToInt16(numArray[1]);
        }
    }
}
