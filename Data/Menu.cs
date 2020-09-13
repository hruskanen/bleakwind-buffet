/*
* Author: Hunter Ruskanen
* Class name: Menu.cs
* Purpose: creats a list of all the menu items
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Contains all of the methods to create the menu and submenus
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates the sub menu containing all of the Entrees
        /// </summary>
        /// <returns> a list of all of the entrees </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();

            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());

            return entrees;
        }

        /// <summary>
        /// Creates the sub menu containing all of the Drinks
        /// </summary>
        /// <returns> a list of all of the Drinks in each size and flavor </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (Size size in new[] { Size.Small, Size.Medium, Size.Large })
            {
                drinks.Add(new AretinoAppleJuice() { Size = size } );
                drinks.Add(new CandlehearthCoffee() { Size = size });
                drinks.Add(new MarkarthMilk() { Size = size } );
                drinks.Add(new WarriorWater() { Size = size } );
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda() { Flavor = flavor, Size = size });
                }
            }

            return drinks;
        }

        /// <summary>
        /// Creates the sub menu containing all of the Sides
        /// </summary>
        /// <returns> a list of all of the sides in each size </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach (Size size in new[] { Size.Small, Size.Medium, Size.Large })
            {
                sides.Add(new DragonbornWaffleFries() { Size = size });
                sides.Add(new FriedMiraak() { Size = size });
                sides.Add(new MadOtarGrits() { Size = size });
                sides.Add(new VokunSalad() { Size = size });
            }

            return sides;
        }

        /// <summary>
        /// Creates the full menu using the 3 sub menus
        /// </summary>
        /// <returns> A List of all item offered </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> meun = new List<IOrderItem>();

            meun.AddRange(Entrees());
            meun.AddRange(Drinks());
            meun.AddRange(Sides());

            return meun;
        }
    }
}
