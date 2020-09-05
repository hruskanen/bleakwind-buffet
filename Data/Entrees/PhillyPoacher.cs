/*
* Author: Hunter Ruskanen
* Class name: PhillyPoacher.cs
* Purpose: To add a Philly Poacher to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Philly Poacher
    /// </summary>
    public class PhillyPoacher
    {
        ///Common 
        public double Price { get; } = 7.23;
        public uint Calories { get; } = 784;

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!sirloin) { temp.Add("Hold Sirloin"); }
                if (!onion) { temp.Add("Hold Onion"); }
                if (!roll) { temp.Add("Hold Roll"); }
                return temp;
            }
        }

        ///Unique
        /// <summary>
        /// Creates public and private bool bun on if the bun should be added
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                sirloin = value;
            }
        }

        /// <summary>
        /// Creates public and private bool onion on if onion should be added
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                onion = value;
            }
        }

        /// <summary>
        /// Creates public and private bool roll on if a roll should be added
        /// </summary>
        private bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                SpecialInstructions.Add("Hold Roll");
            }
        }


        /// <summary>
        /// Returns a description of the Philly Poacher
        /// </summary>
        /// <returns> 
        /// A string describing the Philly Poacher
        /// </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
