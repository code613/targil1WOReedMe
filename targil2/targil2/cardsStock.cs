using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{

    public class CardStock
    {
        public List<Card> Cards = new List<Card>();
        public CardStock()
        {
            for (int i = 0; i < 26; i++)
            {
                if (i < 13)
                {
                    Cards.Add(new Card(E_Color.black, i + 2));
                }
                else
                {
                    Cards.Add(new Card(E_Color.red, i % 13 + 2));
                }
            }
        }

        public void mixCards()
        {
            Random rand = new Random();
            int size = Cards.Count;
            for (int first = 0; first < size; first++)
            {
                int second = rand.Next(size);
                Card tmp = Cards[first];
                Cards[first] = Cards[second];
                Cards[second] = tmp;
            }

        }


        /// <summary>
        /// return names&color of all cards;
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < Cards.Count; i++)
            {
                str += (Cards[i].ToString() + ", ");
            }
            return str;
        }

        public void distribute(params Player[] players)
        {
            while (Cards.Count != 0)
            {
                foreach (Player p in players)
                {
                    p.playerCards.Enqueue(Cards.First());
                    Cards.Remove(Cards.First());
                }
            }
        }


        public void sortCards()
        {
            Cards.Sort();
        }


        public void addCard(Card card1)
        {
            Cards.Add(card1);
        }


        public void removeCard(Card card1)
        {
            Cards.Remove(card1);
        }
    }
                    
}
