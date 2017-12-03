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
            
            Console.WriteLine("you are in war game ,the most fun game in the world.GET READY!!!!!!" );
            Console.WriteLine("enter the name of the first player");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the name of the second player");
            string name2 = Console.ReadLine();
            Game myGame = new Game(name1, name2);
            myGame.startGame();//mix the cards & distrbute to both players.
            
            while (!myGame.isEndGame())//both players has cards.
            {
                if (myGame.makeMove()) 
                    Console.WriteLine("{0} wins this round", myGame.player1.name);
                else
                    Console.WriteLine("{0} wins this round", myGame.player2.name);
            }
            Console.WriteLine(myGame.printWinnerName());
            Console.ReadKey();
        }
    }
}
