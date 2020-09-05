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
    /// <summary>
    /// Class for representing Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        ///Common 
        public double Price = 0.93;
        public uint Calories = 41;

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
        /// Returns a description of the Vokun Salad
        /// </summary>
        /// <returns> 
        /// A string describing the Vokun Salad
        /// </returns>
        public override string ToString()
        {
            return size + " Vokun Salad";
        }
    }
}
