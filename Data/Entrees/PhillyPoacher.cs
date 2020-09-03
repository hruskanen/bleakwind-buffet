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
    class PhillyPoacher
    {
        ///Common 
        double Price { get; } = 7.23;
        uint Calories { get; } = 784;
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
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
