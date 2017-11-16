using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    
    class CardStock
    {
        List <Card> Cards;
        CardStock()
        {
            for (int i=0;i<26;i++)
            {
                if (i<13)
                {
                    Cards.Add(new Card( E_Color.black, i + 2));
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
    }
}
