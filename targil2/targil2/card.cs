using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    enum Royal { jack = 11, queen, king, ace };
    enum E_Color { red, black };
    class Card
    {
        private E_Color color;
        private int number;
        //#region
        internal E_Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value < 2 || value > 14)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                number = value;
            }
        }

        public string cardName()
        {

            if (number < 11)
                return number.ToString();
            else
            {
                Royal c = (Royal)number;
                return c.ToString();
            }
        }
        Card(E_Color col,int num)
        {
            color = col;
            number = num;
        }
       
    }
}
                
 
        

           

