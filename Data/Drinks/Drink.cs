/*
* Author: Hunter Ruskanen
* Class name: Drink.cs
* Purpose: To add a add a base drink
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
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
        public virtual Size Size { get; set; } = Size.Small;

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
