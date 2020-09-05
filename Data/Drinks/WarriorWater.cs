/*
* Author: Hunter Ruskanen
* Class name: WarriorWater.cs
* Purpose: To add a Warrior Water to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Warrior Water
    /// </summary>
    public class WarriorWater
    {
        ///Common 
        public double Price = 0;
        public uint Calories = 0;

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
                if (lemon) { temp.Add("Add Lemon"); }
                return temp;
            }
        }

        /// <summary>
        /// creates private and public sizes
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
        /// Creates public and private bool lemon on if lemon should be added
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// Returns a description of the Warrior Water
        /// </summary>
        /// <returns> 
        /// A string describing the Warrior Water
        /// </returns>
        public override string ToString()
        {
            return size + " Warrior Water";
        }
    }
}
