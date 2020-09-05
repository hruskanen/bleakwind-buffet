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
    /// <summary>
    /// Class for representing Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        ///Common 
        public double Price = 0.42;
        public uint Calories = 77;

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
        /// Returns a description of the Dragonborn Waffle Fries
        /// </summary>
        /// <returns> 
        /// A string describing the Dragonborn Waffle Fries
        /// </returns>
        public override string ToString()
        {
            return size + " Dragonborn Waffle Fries";
        }
    }
}
