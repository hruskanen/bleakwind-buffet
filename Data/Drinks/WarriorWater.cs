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
    public class WarriorWater : Drink
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 0; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 0; } }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions
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
                if (ice != value)
                {
                    ice = value;
                    NotifyPropertyChanged("Ice");
                    NotifyPropertyChanged("SpecialInstructions");
                }
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
                if (lemon != value)
                {
                    lemon = value;
                    NotifyPropertyChanged("Lemon");
                    NotifyPropertyChanged("SpecialInstructions");
                }
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
            return Size + " Warrior Water";
        }
    }
}
