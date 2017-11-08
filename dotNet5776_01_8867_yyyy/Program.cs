using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum options { gessNumber,gessArea,exit};

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

            Array.Sort(numberArray);
            // Array numbers[100];//to random numbers
            //switch () { };
            Console.WriteLine("enter 0 for gessNumber, 1 for gessArea,2 for exit ");
            int number = Convert.ToInt32(Console.ReadLine());
            options c = (options)number;
            switch (c)
            {
                case options.gessNumber:
                    Console.WriteLine("enter a number from 1 to 1000");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (numberArray.Contains(num))
                        Console.WriteLine("number found");
                    else
                        Console.WriteLine("not found");
                    break;
                case options.gessArea:
                    Console.WriteLine("enter a range of numbers and from 1 to 1000");
                    Console.WriteLine("and then another number that gesses how manny are found");
                    string theNumbers = (Console.ReadLine());
                    string[] tokens = theNumbers.Split(new char[] { ' ', '\n', ',' });
                    int[] myInts = Array.ConvertAll(tokens, int.Parse);
                    int maxg = myInts[0];
                    int ming = myInts[1];
                    if (maxg < ming) { int temp = maxg; maxg = ming; ming = temp; }
                    int gess = myInts[2];
                    int counter = 0;
                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        if (numberArray[i] > ming && numberArray[i] < maxg)
                        {
                            counter++;
                        }
                    }
                    if (counter == gess)
                        Console.WriteLine("good gess");
                    else
                        Console.WriteLine("wrong");
                    break;
                case options.exit:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

        }

    }
}

