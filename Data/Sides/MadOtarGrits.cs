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
    public class MadOtarGrits : Side
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
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
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
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
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
        /// The description of the item
        /// </summary>
        public override string description { get { return "Cheesey Grits."; } }

        /// <summary>
        /// Returns a description of the Mad Otar Grits
        /// </summary>
        /// <returns> 
        /// A string describing the Mad Otar Grits
        /// </returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }
    }
}
