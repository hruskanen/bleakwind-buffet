/*
* Author: Hunter Ruskanen
* Class name: GardenOrcOmelette.cs
* Purpose: To add a Garden Orc Omelette to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class GardenOrcOmelette
    {
        ///Common 
        double Price { get; } = 4.57;
        uint Calories { get; } = 404;
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!broccoli) { temp.Add("Hold Broccoli"); }
                if (!mushrooms) { temp.Add("Hold Mushrooms"); }
                if (!tomato) { temp.Add("Hold Tomato"); }
                if (!cheddar) { temp.Add("Hold Cheddar"); }
                return temp;
            }
        }

        ///Unique
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                broccoli = value;
            }
        }

        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
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

        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
