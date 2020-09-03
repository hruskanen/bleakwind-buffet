/*
* Author: Hunter Ruskanen
* Class name: WarriorWater.cs
* Purpose: To add a Warrior Water to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class WarriorWater
    {
        ///Common 
        double Price = 0;
        uint Calories = 0;
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> temp = new List<string>();
                if (!ice) { temp.Add("Hold Ice"); }
                if (lemon) { temp.Add("Add Lemon"); }
                return temp;
            }
        }

        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }


        ///Unique
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }



        public override string ToString()
        {
            return size + " Warrior Water";
        }
    }
}
