/*
* Author: Hunter Ruskanen
* Class name: DragonbornWaffleFries.cs
* Purpose: To add a Dragonborn Waffle Fries to the Side menu
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
    {
        ///Common 
        double Price = 0.42;
        uint Calories = 77;
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
                    Price = 0.42;
                    Calories = 77;
                }
                else if (Size.Medium == value)
                {
                    Price = 0.76;
                    Calories = 89;
                }
                else if (Size.Large == value)
                {
                    Price = 0.96;
                    Calories = 100;
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
            return size + " Dragonborn Waffle Fries";
        }
    }
}
