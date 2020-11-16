/*
* Author: Hunter Ruskanen
* Class name: CandlehearthCoffee.cs
* Purpose: To add a Candle hearth Coffee to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (ice) { temp.Add("Add Ice"); }
                if (roomForCream) { temp.Add("Add Cream"); }
                return temp;
            }
        }

        /// <summary>
        /// Creates public and private bool Ice on if ice should be added
        /// </summary>
        private bool ice = false;
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
        /// Creates public and private bool roomForCream on if there should be room
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                if (roomForCream != value)
                {
                    roomForCream = value;
                    NotifyPropertyChanged("RoomForCream");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool decaf on if it should be decaf or not
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    NotifyPropertyChanged("Decaf");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string description { get { return "Fair trade, fresh ground dark roast coffee."; } }

        /// <summary>
        /// Returns a description of the Candlehearth Coffee
        /// </summary>
        /// <returns> 
        /// A string describing the Candlehearth Coffee
        /// </returns>
        public override string ToString()
        {
            if (decaf) return Size + " Decaf Candlehearth Coffee";
            else return Size + " Candlehearth Coffee";
        }
    }
}
