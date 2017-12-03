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
        /// <summary>
        /// if one of the players print the seconds name.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// compare both players first cards.
        /// </summary>
        /// <returns></returns>
        public bool makeMove()
        {
            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());
            Card firstCard = player1.pop();
            Card secondCard = player2.pop();
            Console.WriteLine("{0} played {1} {2} played {3}", player1.name, firstCard, player2.name, secondCard);

            if (firstCard.Number > secondCard.Number)
            {
                player1.addCard(firstCard, secondCard);
                return true; 
            }
            else if (secondCard.Number > firstCard.Number)
            {
                player2.addCard(firstCard, secondCard);
                return false;
            }
            else //case both cards are equal.
            {
                return warPlay(firstCard,secondCard);
            }
               
        }

        public bool warPlay(Card cd1, Card cd2)
        {
            
            Console.WriteLine("WAR WAR WAR WAR WAR");
            Console.WriteLine("there is a WAR becouse there are two {0}", cd1.Number);
            List<Card> war = new List<Card>();
            war.Add(cd1);
            war.Add(cd2);
            war.Add(player1.pop());
            war.Add(player2.pop());
            if (player1.lose()) { return false ;  }//case he dosent have enough cards for war.
            if (player2.lose()) { return true; }
            if (makeMove())//case player 1 wins the war
            {
                foreach(Card c in war)
                {
                    player1.addCard(c);
                }
                return true;
            }
            else     //case player 2 wins the war
            {
                foreach (Card c in war)
                {
                    player2.addCard(c);
                }
                return false;
            }
        }
    }
}