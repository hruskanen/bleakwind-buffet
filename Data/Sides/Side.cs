﻿/*
* Author: Hunter Ruskanen
* Class name: Side.cs
* Purpose: To add a add a base side
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Base class reperesenting the drinks
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
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
                    NotifyPropertyChanged("Price");
                    NotifyPropertyChanged("Calories");
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

        /// <summary>
        /// The description of the item
        /// </summary>
        public abstract string description { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
