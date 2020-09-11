/*
* Author: Hunter Ruskanen
* Class name: AretinoAppleJuice.cs
* Purpose: To add a Aretino Apple Juice to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (ice) { temp.Add("Add Ice"); }
                return temp;
            }
        }

        /// <summary>
        /// Creates public and private bool Ice on if ice should be added
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Returns a description of the Aretino Apple Juice
        /// </summary>
        /// <returns> 
        /// A string describing the AretineoApple Juice
        /// </returns>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}
