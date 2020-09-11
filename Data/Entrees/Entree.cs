/*
* Author: Hunter Ruskanen
* Class name: Entree.cs
* Purpose: To add a add a base entree
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Base class reperesenting the entrees
    /// </summary>
    public abstract class Entree
    {
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
