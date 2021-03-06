﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    public enum Royal { jack = 11, queen, king, ace };
    public enum E_Color { red, black };

    public class Card : IComparable<Card>
    {
        private E_Color color=new E_Color();
        private int number;

        public Card(E_Color col, int num)
        {
            color = col;
            number = num; 
        }
        #region properties
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
                number = value;
            }
            #endregion 
        }
        public override string ToString()
        {
            if (number < 11)
                return  color + " " + number;
            else
            {
            return  color + " " + (Royal)number;   
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
        /// <summary>
        /// will compare two cards acorrding to theyr number.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Card other)
        {
            return number.CompareTo(other.number);
        }
    }
}
