/*
* Author: Hunter Ruskanen
* Class name: ThugsTBone.cs
* Purpose: To add a Thugs T-Bone to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        ///Common 
        double Price { get; } = 6.44;
        uint Calories { get; } = 982;
        List<string> SpecialInstructions { get; }

        ///Unique


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}