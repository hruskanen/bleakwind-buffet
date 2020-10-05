/*
* Author: Hunter Ruskanen
* Class name: IOrderItem.cs
* Purpose: To add a add a IOrderItem interface
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The size of the drinks
        /// </summary>
        Size Size { get; set; }

        /// <summary>
        /// The price of the drinks
        /// </summary>
        /// <value> In dollars </value>
        double Price { get; }

        /// <summary>
        /// The calorie count for the drinks
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the drinks
        /// </summary>
        List<string> SpecialInstructions { get; }

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
