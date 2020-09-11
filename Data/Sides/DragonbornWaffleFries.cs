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
    public class DragonbornWaffleFries : Side
    {
        ///Common 
        /// <summary>
        /// The price for the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// The amount of calories for the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the Dragonborn Waffle Fries
        /// </summary>
        /// <returns> 
        /// A string describing the Dragonborn Waffle Fries
        /// </returns>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
