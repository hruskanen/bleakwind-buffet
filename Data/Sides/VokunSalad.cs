/*
* Author: Hunter Ruskanen
* Class name: VokunSalad.cs
* Purpose: To add a Vokun Salad to the Side menu
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
    {
        ///Common 
        double Price = 0.93;
        uint Calories = 41;
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
                    Price = 0.93;
                    Calories = 41;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.28;
                    Calories = 52;
                }
                else if (Size.Large == value)
                {
                    Price = 1.82;
                    Calories = 73;
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
            return size + " Vokun Salad";
        }
    }
}
