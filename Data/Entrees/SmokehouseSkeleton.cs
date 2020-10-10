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
    /// <summary>
    /// Class for representing Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        ///Common 
        /// <summary>
        /// The price for the drink
        /// </summary>
        public override double Price { get { return 5.62; } }
        /// <summary>
        /// The amount of calories for the drink
        /// </summary>
        public override uint Calories { get { return 602; } }

        /// <summary>
        /// Creates the SpecialInstructions list and adds items to
        /// the list based on if a varible had changed from its default
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!sausageLink) { temp.Add("Hold Sausage Link"); }
                if (!egg) { temp.Add("Hold Egg"); }
                if (!hashBrowns) { temp.Add("Hold HashBrowns"); }
                if (!pancake) { temp.Add("Hold Pancake"); }
                return temp;
            }
        }

        ///Unique
        /// <summary>
        /// Creates public and private bool sausageLink on if the sausageLink should be added
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                if (sausageLink != value)
                {
                    sausageLink = value;
                    NotifyPropertyChanged("SausageLink");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool egg on if the egg should be added
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (egg != value)
                {
                    egg = value;
                    NotifyPropertyChanged("Egg");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool hashBrowns on if the hash Browns should be added
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                if (hashBrowns != value)
                {
                    hashBrowns = value;
                    NotifyPropertyChanged("HashBrowns");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Creates public and private bool pancake on if the pancakes should be added
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                if (pancake != value)
                {
                    pancake = value;
                    NotifyPropertyChanged("Pancake");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }


        /// <summary>
        /// Returns a description of the Smokehouse Skeleton
        /// </summary>
        /// <returns> 
        /// A string describing the Smokehouse Skeleton
        /// </returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
