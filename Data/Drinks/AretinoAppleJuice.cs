/*
* Author: Hunter Ruskanen
* Class name: AretinoAppleJuice.cs
* Purpose: To add a Aretino Apple Juice to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class AretinoAppleJuice
    {
        ///Common 
        double Price = 0.62;
        uint Calories = 44;
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
                    Price = 0.62;
                    Calories = 44;
                }
                else if (Size.Medium == value)
                {
                    Price = 0.87;
                    Calories = 88;
                }
                else if (Size.Large == value)
                {
                    Price = 1.01;
                    Calories = 132;
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
            return size + " Aretine Apple Juice";
        }
    }
}
