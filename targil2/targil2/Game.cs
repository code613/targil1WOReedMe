using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    class Game
    {
        CardStock gameCards;
        Player player1, player2;
        public void startGame()
        {
            gameCards.mixCards();
            gameCards.distribute();
        }
        public string printWinerName()
        {
            if (player1.lose())
                return player2.name + "is the great winner";
            return player1.name + "is the great winner";

        }
        public bool isEndGame()
        {
            if (player1.lose() || player2.lose())
                return true;
            return false;
        }
        public void makeMove()
        {
            Card player1Card = player1.playrCards.First();
            Card player2Card = player2.playrCards.First();
            player1.pop();
            player2.pop();
            if (player1Card.Number> player2Card.Number)
            {
                player1.addCard(player1Card, player2Card);
            }
            else if (player2Card.Number > player1Card.Number)
            {
                player2.addCard(player1Card, player2Card);
            }
            else
            {

            }
            if (isEndGame())
            {
                Console.WriteLine(printWinerName());
                return;
            }
        }
    }
}
