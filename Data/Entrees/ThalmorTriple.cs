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
    public class ThalmorTriple
    {
        ///Common 
        public double Price { get; } = 8.32;
        public uint Calories { get; } = 943;

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public List<string> SpecialInstructions
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
                bun = value;
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
                ketchup = value;
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
                mustard = value;
            }
        }

        /// <summary>
        /// Creates public and private bool pickle on if the pickles should be added
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
                pickle = value;
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
                cheese = value;
            }
        }

        /// <summary>
        /// Creates public and private bool tomato on if the tomatos should be added
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
                tomato = value;
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
                lettuce = value;
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
                mayo = value;
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
                bacon = value;
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
                egg = value;
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
