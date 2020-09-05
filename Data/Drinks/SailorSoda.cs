/*
* Author: Hunter Ruskanen
* Class name: SailorSoda.cs
* Purpose: To add a Sailor Soda to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Sailor Soda
    /// </summary>
    public class SailorSoda
    {
        ///Common 
        public double Price = 1.42;
        public uint Calories = 117;

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!ice) { temp.Add("Hold Ice"); }
                return temp;
            }
        }

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
                    Price = 1.42;
                    Calories = 117;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.74;
                    Calories = 153;
                }
                else if (Size.Large == value)
                {
                    Price = 2.07;
                    Calories = 205;
                }
                else
                {
                    throw new NotImplementedException("Unknown size " + Size);
                }
            }
        }

        /// <summary>
        /// Creates public and private bool Ice on if ice should be added
        /// </summary>
        private bool ice = true;
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


        ///Unique
        /// <summary>
        /// Creates public and private SodaFlavor flavor on what flavor it should be
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Returns a description of the Sailor Soda
        /// </summary>
        /// <returns> 
        /// A string describing the Sailor Soda
        /// </returns>
        public override string ToString()
        {
            return size + " " + flavor + " Sailor Soda";
        }
    }
}
