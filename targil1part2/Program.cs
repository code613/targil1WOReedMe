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
            char[] seperaters = new char[] { ' ', '\n', ',', '\t' };
            Console.WriteLine("enter 5 sets of 5 numbers");
            int[,] numbers = new int[5, 5];
            
            Console.WriteLine("after 5 numbers press enter");
            for (int i = 0; i < 5; i++)
            {
            bool flag1 = true;
                string theNumbers = (Console.ReadLine());
                string[] tokens = theNumbers.Split(seperaters);
                    int[] myInts = Array.ConvertAll(tokens, int.Parse);
                    int size = myInts.Length;
                if (size != 5)//for size to big error...  still need for end with spase error
                {
                    i--;
                    Console.WriteLine("incorect amount of numbers typed please try again : typed {0}", size);
                    flag1 = false;//so incurect data won't go into the array
                }
                for (int j = 0, k = 0; j < 5 && flag1; j++)
                {
                    numbers[i, j] = myInts[k++];
                }
                if (i!=4)
                Console.WriteLine("enter next 5 numbers for level {0}",i+2);
            }
            
            if(magicSquere(numbers,5))
                Console.WriteLine("yes a magic Squere");
            else
                Console.WriteLine("not a magic Squere");
            Console.ReadKey();
            
        }
        static bool magicSquere(int[,]a,int size)
        {
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
                if (sum!=firstLine ) return false;
            }

            //check the column 
            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                for (int j = 0; j < size; j++)
                {
                     sum  += a[j,i];
                }
                if ( sum  != firstLine) return false;
            }
            //check  left to right diagonal
            int sum1 = 0;
            for (int i=0 ,j=0;i< size; i++,j++)
            {
                sum1 += a[i, j];
            }
            if (sum1 != firstLine) return false;

            //check right to left diagonal
            int sum2 = 0;
            for (int i = 0, j = size - 1; i<size; i++, j--)
            {
                sum2 += a[i, j];
            }
            if (sum2 != firstLine) return false;

            return true;
        }
    }
}