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
    /// <summary>
    /// Class for representing Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 4.57; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 404; } }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <summary>
        /// Creates public and private bool broccoli on if the broccoli should be added
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                if (broccoli != value)
                {
                    broccoli = value;
                    NotifyPropertyChanged("Broccoli");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool mushrooms on if the mushrooms should be added
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    NotifyPropertyChanged("Mushrooms");
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
        /// Creates public and private bool cheddar on if the cheddar should be added
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    NotifyPropertyChanged("Cheddar");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }


        /// <summary>
        /// Returns a description of the Garden Orc Omelette
        /// </summary>
        /// <returns> 
        /// A string describing the Garden Orc Omelette
        /// </returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
