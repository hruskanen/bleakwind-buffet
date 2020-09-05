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
    /// <summary>
    /// Class for representing Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        ///Common 
        public double Price = 1.22;
        public uint Calories = 105;

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// creates private and public sizes and changes Calories and Price accordingly
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
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
        /// Returns a description of the Mad Otar Grits
        /// </summary>
        /// <returns> 
        /// A string describing the Mad Otar Grits
        /// </returns>
        public override string ToString()
        {
            return size + " Mad Otar Grits";
        }
    }
}
