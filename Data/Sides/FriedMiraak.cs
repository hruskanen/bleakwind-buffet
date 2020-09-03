/*
* Author: Hunter Ruskanen
* Class name: FriedMiraak.cs
* Purpose: To add a Fried Miraak to the Side menu
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class FriedMiraak
    {
        ///Common 
        double Price = 1.78;
        uint Calories = 151;
        List<string> SpecialInstructions { get; }
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
                    Price = 1.78;
                    Calories = 151;
                }
                else if (Size.Medium == value)
                {
                    Price = 2.01;
                    Calories = 236;
                }
                else if (Size.Large == value)
                {
                    Price = 2.88;
                    Calories = 306;
                }
                else
                {
                    throw new NotImplementedException("Unknown size " + Size);
                }
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return size + " Fried Miraak";
        }
    }
}
