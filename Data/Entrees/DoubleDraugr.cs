/*
* Author: Hunter Ruskanen
* Class name: DoubleDraugr.cs
* Purpose: To add a Double Draugr to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 7.32; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 843; } }

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
                if (!tomato) { temp.Add("Hold Tomato"); }
                if (!lettuce) { temp.Add("Hold Lettuce"); }
                if (!mayo) { temp.Add("Hold Mayo"); }
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
        /// Creates public and private bool tomatos on if the tomatos should be added
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    NotifyPropertyChanged("Tomato");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool lettuce on if the lettuce should be added
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                if (lettuce != value)
                {
                    lettuce = value;
                    NotifyPropertyChanged("Lettuce");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool mayo on if the mayo should be added
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                if (mayo != value)
                {
                    mayo = value;
                    NotifyPropertyChanged("Mayo");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }


        /// <summary>
        /// Returns a description of the Double Draugr
        /// </summary>
        /// <returns> 
        /// A string describing the Double Draugr
        /// </returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
