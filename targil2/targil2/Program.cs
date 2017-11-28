using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{

    class Program
    {
        static void Main(string[] args)
        {
            CardStock cs = new CardStock();
            Console.WriteLine("you are in war game ,the most fun game in the world.GET READY!!!!!!" );
            Console.WriteLine("enter the name of the first player");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of the second player");
            string name2 = Console.ReadLine();
            Game myGame = new Game(name1, name2);
            myGame.startGame();
            while (!myGame.isEndGame())
            {
                myGame.makeMove(out winner);
                Console.WriteLine("{0} wins this round", winner);
            }
            myGame.printWinnerName();
            Console.ReadKey();
        }
    }
}
