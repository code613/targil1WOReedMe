using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    public class Player
    {
        public string name;
        public Queue <Card> playrCards;
        /// <summary>
        /// tostring return name ,sum of cards and what cards; 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str=null;
            foreach (Card C in playrCards)
            {
                str += C;
            }
            return name + playrCards.Count + str;
        }
        /// <summary>
        /// check if playr as no 
        /// cards and then he lose the game;
        /// </summary>
        /// <returns></returns>
        public bool lose()
        {
            if (playrCards.Count == 0) return true;
            return false;
        }
        /// <summary>
        /// add cards to end of queue;
        /// </summary>
        /// <param name="listc"></param>
        public void addCard(params  Card[] listc)
        {
            foreach (Card C in listc)
            {
                playrCards.Enqueue(C);
            }
        }
        /// <summary>
        /// exit the first card;
        /// </summary>
        public void pop()
        {
            playrCards.Dequeue();
        }
    }

   
    
}
