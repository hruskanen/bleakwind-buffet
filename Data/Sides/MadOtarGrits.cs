/*
* Author: Hunter Ruskanen
* Class name: MadOtarGrits.cs
* Purpose: To add a Mad Otar Grits to the Side menu
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class MadOtarGrits
    {
        ///Common 
        double Price = 1.22;
        uint Calories = 105;
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
                    Price = 1.22;
                    Calories = 105;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.58;
                    Calories = 142;
                }
                else if (Size.Large == value)
                {
                    Price = 1.93;
                    Calories = 179;
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
            return size + " Mad Otar Grits";
        }
    }
}
