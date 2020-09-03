/*
* Author: Hunter Ruskanen
* Class name: MarkarthMilk.cs
* Purpose: To add a Markarth Milk to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class MarkarthMilk
    {
        ///Common 
        double Price = 1.05;
        uint Calories = 56;
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!ice) { temp.Add("Hold Ice"); }
                return temp;
            }
        }

        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (Size.Small == value)
                {
                    Price = 1.05;
                    Calories = 56;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.11;
                    Calories = 72;
                }
                else if (Size.Large == value)
                {
                    Price = 1.22;
                    Calories = 93;
                }
                else
                {
                    throw new NotImplementedException("Unknown size " + Size);
                }
            }
        }

        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }


        public override string ToString()
        {
            return size + " Markarth Milk";
        }
    }
}
