/*
* Author: Hunter Ruskanen
* Class name: MarkarthMilk.cs
* Purpose: To add a Markarth Milk to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        ///Common 
        public double Price = 1.05;
        public uint Calories = 56;

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
                    Price = 1.05;
                    Calories = 56;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.11;
                    Calories = 72;
                }
                else if (Size.Large == value)
                {
                    Price = 1.22;
                    Calories = 93;
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
        /// Returns a description of the Markarth Milk
        /// </summary>
        /// <returns> 
        /// A string describing the Markarth Milk
        /// </returns>
        public override string ToString()
        {
            return size + " Markarth Milk";
        }
    }
}
