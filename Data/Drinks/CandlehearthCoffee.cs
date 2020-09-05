/*
* Author: Hunter Ruskanen
* Class name: CandlehearthCoffee.cs
* Purpose: To add a Candle hearth Coffee to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        ///Common 
        public double Price = 0.75;
        public uint Calories = 7;

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public List<string> SpecialInstructions
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
        /// creates private and public sizes and changes Calories and Price accordingly
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (Size.Small == value)
                {
                    Price = 0.75;
                    Calories = 7;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.25;
                    Calories = 10;
                }
                else if (Size.Large == value)
                {
                    Price = 1.75;
                    Calories = 20;
                }
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
                ice = value;
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
                roomForCream = value;
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
                decaf = value;
            }
        }

        /// <summary>
        /// Returns a description of the Candlehearth Coffee
        /// </summary>
        /// <returns> 
        /// A string describing the Candlehearth Coffee
        /// </returns>
        public override string ToString()
        {
            if (decaf) return size + " Decaf Candlehearth Coffee";
            else return size + " Candlehearth Coffee";
        }
    }
}
