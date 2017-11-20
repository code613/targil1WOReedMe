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
           
        }
        public void startGame()
        {
            gameCards.mixCards();
            gameCards.distribute(player1, player2);
        }

        public string printWinnerName()
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
                Card firstCard = player1.pop();
                Card secondCard = player2.pop();

                if (firstCard.Number > secondCard.Number)
                {
                    player1.addCard(firstCard, secondCard);
                }
                else if (secondCard.Number > firstCard.Number)
                {
                    player2.addCard(firstCard, secondCard);
                }
                else       //case both cards are equal;need to fix;
                {
                    List<Card> war = new List<Card>();
                    war.Add(player1.pop());
                    war.Add(player1.pop());
                    war.Add(player2.pop());
                    war.Add(player2.pop());
                }
            }
            Console.WriteLine(printWinnerName());
        }
    }
}
