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

            drinks.Add(new AretinoAppleJuice() { Size = Size.Small });
            drinks.Add(new AretinoAppleJuice() { Size = Size.Medium });
            drinks.Add(new AretinoAppleJuice() { Size = Size.Large });

            drinks.Add(new CandlehearthCoffee() { Size = Size.Small });
            drinks.Add(new CandlehearthCoffee() { Size = Size.Medium });
            drinks.Add(new CandlehearthCoffee() { Size = Size.Large });

            drinks.Add(new MarkarthMilk() { Size = Size.Small });
            drinks.Add(new MarkarthMilk() { Size = Size.Medium });
            drinks.Add(new MarkarthMilk() { Size = Size.Large });

            drinks.Add(new WarriorWater() { Size = Size.Small });
            drinks.Add(new WarriorWater() { Size = Size.Medium });
            drinks.Add(new WarriorWater() { Size = Size.Large });

            foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
            {
                drinks.Add(new SailorSoda() { Flavor = flavor, Size = Size.Small });
                drinks.Add(new SailorSoda() { Flavor = flavor, Size = Size.Medium });
                drinks.Add(new SailorSoda() { Flavor = flavor, Size = Size.Large });
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
            sides.Add(new DragonbornWaffleFries() { Size = Size.Small });
            sides.Add(new DragonbornWaffleFries() { Size = Size.Medium });
            sides.Add(new DragonbornWaffleFries() { Size = Size.Large });

            sides.Add(new FriedMiraak() { Size = Size.Small });
            sides.Add(new FriedMiraak() { Size = Size.Medium });
            sides.Add(new FriedMiraak() { Size = Size.Large });

            sides.Add(new MadOtarGrits() { Size = Size.Small });
            sides.Add(new MadOtarGrits() { Size = Size.Medium });
            sides.Add(new MadOtarGrits() { Size = Size.Large });

            sides.Add(new VokunSalad() { Size = Size.Small });
            sides.Add(new VokunSalad() { Size = Size.Medium });
            sides.Add(new VokunSalad() { Size = Size.Large });

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
