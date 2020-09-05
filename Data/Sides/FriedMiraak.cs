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
    /// <summary>
    /// Class for representing Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        ///Common 
        public double Price = 1.78;
        public uint Calories = 151;

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
        /// Returns a description of the Fried Miraak
        /// </summary>
        /// <returns> 
        /// A string describing the Fried Miraak
        /// </returns>
        public override string ToString()
        {
            return size + " Fried Miraak";
        }
    }
}
