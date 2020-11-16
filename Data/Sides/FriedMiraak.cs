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
    public class FriedMiraak : Side
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
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
        public override string description { get { return "Perfectly prepared hash brown pancakes."; } }

        /// <summary>
        /// Returns a description of the Fried Miraak
        /// </summary>
        /// <returns> 
        /// A string describing the Fried Miraak
        /// </returns>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }
    }
}
