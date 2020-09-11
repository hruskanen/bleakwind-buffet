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
    public class VokunSalad : Side
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
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
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
        /// Returns a description of the Vokun Salad
        /// </summary>
        /// <returns> 
        /// A string describing the Vokun Salad
        /// </returns>
        public override string ToString()
        {
            return Size + " Vokun Salad";
        }
    }
}
