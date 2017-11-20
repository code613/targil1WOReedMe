using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    class Game
    {
        public CardStock gameCards = new CardStock();
        public Player player1 = new Player();
        public Player player2 = new Player();
        public Game(string name1,string name2)
        {
            player1.name = name1;
            player2.name = name2;
            gameCards.mixCards();
            gameCards.distribute(player1, player2);
        }
        public string printWinerName()
        {
            if (player1.lose())
                return player2.name + " is the great winner";
            return player1.name + " is the great winner";

        }
        public bool isEndGame()
        {
            if (player1.lose() || player2.lose())
                return true;
            return false;
        }
        public void makeMove()
        {
            while (!isEndGame())
            {
                Card player1Card = player1.playrCards.First();
                Card player2Card = player2.playrCards.First();
                player1.pop();
                player2.pop();
                if (player1Card.Number+10 > player2Card.Number)
                {
                    player1.addCard(player1Card, player2Card);
                }
                else
                {
                    player2.addCard(player1Card, player2Card);
                }
            }
            Console.WriteLine(printWinerName());
        }
    }
}
