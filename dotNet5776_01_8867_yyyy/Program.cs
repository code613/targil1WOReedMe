using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum options { gessNumber,gessArea,exeit};

namespace dotNet5776_01_8867_7245
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 1000;
            int[] numberArray = new int[100];
            Random ranNum = new Random();
            for (int i = 0; i < numberArray.Length; i++)
              numberArray[i] = ranNum.Next(min, max);

            numberArray.OrderByDescending();
                // Array numbers[100];//to random numbers
                //switch () { };
                Console.WriteLine("enter 0 for gessNumber, 1 for gessArea,2 for exeit ");
           string choice = Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());
            options c = (options)number;
          switch (c)
      {
          case options.gessNumber:
              Console.WriteLine("enter a number from 1 to 1000");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if( numberArray.Contains(num))
                        Console.WriteLine("number found");
                    else
                        Console.WriteLine("not found");
                        break;
          case options.gessArea:
                    Console.WriteLine("enter a range of numbers and from 1 to 1000");
                    Console.WriteLine("and then another number that gesses how manny are found");
                    string theNumbers = (Console.ReadLine());
                    string[] tokens = theNumbers.Split(new char[] { ' ', '\n', ',' });
                    int[] myInts = Array.ConvertAll(tokens);
                    int maxg = Convert.ToInt16(tokens[0]);
                    int ming = Convert.ToInt16(tokens[1]);
                    if (maxg < ming) { int temp = maxg; maxg = ming; ming = temp; }
                    int gess = Convert.ToInt16(tokens[2]);
                    numberArray.
                    break;
          case options.exeit:
              Console.WriteLine("Case 2");
              break;
                default:
              Console.WriteLine("Default case");
              break;

    }
           
        }
       
    }

