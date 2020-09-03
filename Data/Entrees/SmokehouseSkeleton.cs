/*
* Author: Hunter Ruskanen
* Class name: SmokehouseSkeleton.cs
* Purpose: To add a Smokehouse Skeleton to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class SmokehouseSkeleton
    {
        ///Common 
        double Price { get; } = 5.62;
        uint Calories { get; } = 602;
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!sausageLink) { temp.Add("Hold Sausage Link"); }
                if (!egg) { temp.Add("Hold Egg"); }
                if (!hashBrowns) { temp.Add("Hold Hash Browns"); }
                if (!pancake) { temp.Add("Hold Pancake"); }
                return temp;
            }
        }

        ///Unique
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                sausageLink = value;
            }
        }

        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
            }
        }

        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                hashBrowns = value;
            }
        }

        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
