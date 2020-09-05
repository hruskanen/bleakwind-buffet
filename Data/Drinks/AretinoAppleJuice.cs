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
    public class AretinoAppleJuice
    {
        ///Common 
        public double Price = 0.62;
        public uint Calories = 44;

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (ice) { temp.Add("Add Ice"); }
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
                    Price = 0.62;
                    Calories = 44;
                }
                else if (Size.Medium == value)
                {
                    Price = 0.87;
                    Calories = 88;
                }
                else if (Size.Large == value)
                {
                    Price = 1.01;
                    Calories = 132;
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
            return size + " Aretino Apple Juice";
        }
    }
}
