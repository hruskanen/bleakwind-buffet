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
    public class ThugsTBone : Entree
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 6.44; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 982; } }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();


        /// <summary>
        /// The description of the item
        /// </summary>
        public override string description { get { return "Juicy T-Bone, not much else to say."; } }


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