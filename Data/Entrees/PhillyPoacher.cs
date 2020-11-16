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
    public class PhillyPoacher : Entree
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 7.23; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 784; } }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions
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
                if (sirloin != value)
                {
                    sirloin = value;
                    NotifyPropertyChanged("Sirloin");
                    NotifyPropertyChanged("SpecialInstructions");
                }
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
                if (onion != value)
                {
                    onion = value;
                    NotifyPropertyChanged("Onion");
                    NotifyPropertyChanged("SpecialInstructions");
                };
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
                if (roll != value)
                {
                    roll = value;
                    NotifyPropertyChanged("Roll");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string description { get { return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll."; } }


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
