﻿/*
* Author: Hunter Ruskanen
* Class name: BriarheartBurger.cs
* Purpose: To add a Briarheart Burger to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 6.32; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 743; } }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!bun) { temp.Add("Hold Bun"); }
                if (!ketchup) { temp.Add("Hold Ketchup"); }
                if (!mustard) { temp.Add("Hold Mustard"); }
                if (!pickle) { temp.Add("Hold Pickle"); }
                if (!cheese) { temp.Add("Hold Cheese"); }
                return temp;
            }
        }


        ///Unique
        /// <summary>
        /// Creates public and private bool bun on if the bun should be added
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                if (bun != value)
                {
                    bun = value;
                    NotifyPropertyChanged("Bun");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            } 
        }

        /// <summary>
        /// Creates public and private bool ketchup on if the ketchup should be added
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    NotifyPropertyChanged("Ketchup");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool mustard on if the mustard should be added
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    NotifyPropertyChanged("Mustard");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool pickles on if the pickles should be added
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    NotifyPropertyChanged("Pickle");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool cheese on if the cheese should be added
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    NotifyPropertyChanged("Cheese");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string description { get { return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese."; } }


        /// <summary>
        /// Returns a description of the Briarheart Burger
        /// </summary>
        /// <returns> 
        /// A string describing the Briarheart Burger
        /// </returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
