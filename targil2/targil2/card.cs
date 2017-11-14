using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    enum Royal { jack = 11, queen, king, ace };
    enum E_Color { red, black };
    class card
    {
        private E_Color color;
        private int number;
        //#region
        card(E_Color col, int t) {

        };
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
        public override string ToString()
        {
            if (number < 11)
                return "card: " + color + " " + number;
            else
            {
            return "card: " + color + " " + (Royal)number;   
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
    }
}
enum Royel { j,q,k,a };
    enum E_Color { black, red };
    class card
    {
        private
        E_Color color;
        int number;

        public string  Number
        {
            get
            {
                return ToString((Royel)number);
            }
        }

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

    }
}
