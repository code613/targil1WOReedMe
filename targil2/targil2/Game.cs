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
        public void makeMove(out string winner)
        {      
            Card firstCard = player1.pop();
            Card secondCard = player2.pop();
            Console.WriteLine("{0} played {1} {2} played {3}", player1.name, firstCard, player2.name, secondCard);

            if (firstCard.Number > secondCard.Number)
            {
                player1.addCard(firstCard, secondCard);
                winner =  player1.name;
            }
            else if (secondCard.Number > firstCard.Number)
            {
                player2.addCard(firstCard, secondCard);
                Console.WriteLine("{0} wins this round", player2.name);
            }
            else
                warPlay(firstCard);
        }

        public void warPlay(Card cd)
        {
            Console.WriteLine("WAR WAR WAR WAR WAR");
            Console.WriteLine("there is a WAR becouse there are 2 {0}", cd.Number);
            List<Card> war;// = new List<Card>();
            war.Add(player1.pop());
            war.Add(player2.pop());
            if (player1.lose()) { return;  }
            if (player2.lose()) { return; }
            war.Add(player1.pop());
            war.Add(player2.pop());
            makeMove(out winner);
            if (player1.name == winner)
            {
                foreach(Card C in war)
                {

                }
            }
        }
    }
}