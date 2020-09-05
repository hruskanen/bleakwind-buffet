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
    /// <summary>
    /// Class for representing Thugs T-Bone
    /// </summary>
    public class ThugsTBone
    {
        ///Common 
        public double Price { get; } = 6.44;
        public uint Calories { get; } = 982;

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

        ///Unique


        /// <summary>
        /// Returns a description of the Thugs T-Bone
        /// </summary>
        /// <returns> 
        /// A string describing the Thugs T-Bone
        /// </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}