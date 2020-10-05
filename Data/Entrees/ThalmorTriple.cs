/*
* Author: Hunter Ruskanen
* Class name: ThalmorTriple.cs
* Purpose: To add a Thalmor Triple to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 8.32; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 943; } }

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
                if (!bacon) { temp.Add("Hold Bacon"); }
                if (!egg) { temp.Add("Hold Egg"); }
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
                }
            }
        }

        /// <summary>
        /// Creates public and private bool bacon on if the bacon should be added
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                if (bacon != value)
                {
                    bacon = value;
                    NotifyPropertyChanged("Bacon");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool egg on if the egg should be added
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (egg != value)
                {
                    egg = value;
                    NotifyPropertyChanged("Egg");
                }
            }
        }


        /// <summary>
        /// Returns a description of the Thalmor Triple
        /// </summary>
        /// <returns> 
        /// A string describing the Thalmor Triple
        /// </returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
