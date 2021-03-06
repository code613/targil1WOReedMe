﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    public class Player
    {
        public string name;
        public Queue<Card> playerCards = new Queue<Card>();
        

        /// <summary>
        /// tostring return name ,sum of cards and what cards; 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str=null;
            foreach (Card C in playerCards)
            {
                str += C + ", ";
            }
            return name + " has " + playerCards.Count + " cards : " + str;
        }


        /// <summary>
        /// check if player has no 
        /// cards and then he lose the game;
        /// </summary>
        /// <returns></returns>
        public bool lose()
        {
            if (playerCards.Count == 0) return true;
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
                playerCards.Enqueue(C);
            }
        }


        /// <summary>
        ///return the first card && exit the first card;
        /// </summary>
        public Card pop()
        {
            Card tmp = playerCards.First();
            playerCards.Dequeue();
            return tmp;
        }
    }    
}
