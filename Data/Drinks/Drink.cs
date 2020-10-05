/*
* Author: Hunter Ruskanen
* Class name: Drink.cs
* Purpose: To add a add a base drink
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Base class reperesenting the drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drinks
        /// </summary>
        private Size size = Size.Small;
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                if (size != value)
                {
                    size = value;
                    NotifyPropertyChanged("Size");
                }
            }
        }

        /// <summary>
        /// The price of the drinks
        /// </summary>
        /// <value> In dollars </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calorie count for the drinks
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the drinks
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
