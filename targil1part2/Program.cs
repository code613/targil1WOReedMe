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
            int[,] numbers = new int[5, 5];
            Console.WriteLine(numbers.Length);
            string theNumbers = (Console.ReadLine());
            string[] tokens = theNumbers.Split(new char[] { ' ', '\n', ',' });
            int[] myInts = Array.ConvertAll(tokens, int.Parse);

            for (int i = 0, k = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    numbers[i, j] = myInts[k++];
                }
            }
            
            if(magicSquere(numbers,5))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
        static bool magicSquere(int[,]a,int size)
        {
            bool isMagic = true;
            int firstLine = 0;
            //check first line ;will check if all lines columns and diagnoles are 
            //equal to that first line

            for (int i = 0; i < size; i++)//get the sum of first line
            {
                firstLine += a[0, i];
            }
            //check lines
            for (int i=1;i< size; i++)
            {
                int sum = 0;
                for (int j=0;j< size; j++)
                {
                    sum += a[i, j];
                }
                if (sum!=firstLine ) isMagic= false;
            }

            //check the column 
            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                for (int j = 0; j < size; j++)
                {
                     sum  += a[j,i];
                }
                if ( sum  != firstLine) isMagic= false;
            }
            //check  left to right diagonal
            int sum1 = 0;
            for (int i=0 ,j=0;i< size; i++,j++)
            {
                sum1 += a[i, j];
            }
            if (sum1 != firstLine) isMagic = false;

            //check right to left diagonal
            int sum2 = 0;
            for (int i = 0, j = size - 1; i<size; i++, j--)
            {
                sum2 += a[i, j];
            }
            if (sum2 != firstLine) isMagic = false;

            return isMagic;
        }
    }
}