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
    class DoubleDraugr
    {
        ///Common 
        double Price { get; } = 7.32;
        uint Calories { get; } = 843;
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
                return temp;
            }
        }

        ///Unique
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
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
