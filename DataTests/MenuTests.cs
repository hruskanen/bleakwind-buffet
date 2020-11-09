/*
 * Author: Hunter Ruskanen
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.DataTests
{
    public class MenuTests
    {
        [Fact]
        public void AllEntreesShouldBePresent()
        {
            List<IOrderItem> entrees = (List<IOrderItem>)Menu.Entrees();

            Assert.Collection(entrees, 
                item => Assert.Equal(new BriarheartBurger().ToString(), item.ToString()),
                item => Assert.Equal(new DoubleDraugr().ToString(), item.ToString()),
                item => Assert.Equal(new GardenOrcOmelette().ToString(), item.ToString()),
                item => Assert.Equal(new PhillyPoacher().ToString(), item.ToString()),
                item => Assert.Equal(new SmokehouseSkeleton().ToString(), item.ToString()),
                item => Assert.Equal(new ThalmorTriple().ToString(), item.ToString()),
                item => Assert.Equal(new ThugsTBone().ToString(), item.ToString())
            );
        }

        [Fact]
        public void AllDrinksShouldBePresent()
        {
            List<IOrderItem> drinks = (List<IOrderItem>)Menu.Drinks();

            Assert.Collection(drinks,
                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Small }.ToString(), item.ToString()),

                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon, Size = Size.Small }.ToString(), item.ToString()),

                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Medium }.ToString(), item.ToString()),

                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon, Size = Size.Medium }.ToString(), item.ToString()),

                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Large }.ToString(), item.ToString()),

                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon, Size = Size.Large }.ToString(), item.ToString())
            );
        }

        [Fact]
        public void AllSidesShouldBePresent()
        {
            List<IOrderItem> sides = (List<IOrderItem>)Menu.Sides();

            Assert.Collection(sides,
                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Small }.ToString(), item.ToString()),

                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Medium }.ToString(), item.ToString()),

                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Large }.ToString(), item.ToString())
            );
        }

        [Fact]
        public void AllItemsShouldBePresent()
        {
            List<IOrderItem> fullMenu = (List<IOrderItem>)Menu.FullMenu();

            Assert.Collection(fullMenu,
                item => Assert.Equal(new BriarheartBurger().ToString(), item.ToString()),
                item => Assert.Equal(new DoubleDraugr().ToString(), item.ToString()),
                item => Assert.Equal(new GardenOrcOmelette().ToString(), item.ToString()),
                item => Assert.Equal(new PhillyPoacher().ToString(), item.ToString()),
                item => Assert.Equal(new SmokehouseSkeleton().ToString(), item.ToString()),
                item => Assert.Equal(new ThalmorTriple().ToString(), item.ToString()),
                item => Assert.Equal(new ThugsTBone().ToString(), item.ToString()),

                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Small }.ToString(), item.ToString()),

                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach, Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon, Size = Size.Small }.ToString(), item.ToString()),

                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Medium }.ToString(), item.ToString()),

                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach, Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon, Size = Size.Medium }.ToString(), item.ToString()),

                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Large }.ToString(), item.ToString()),

                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach, Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon, Size = Size.Large }.ToString(), item.ToString()),

                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Small }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Small }.ToString(), item.ToString()),

                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Medium }.ToString(), item.ToString()),

                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Large }.ToString(), item.ToString())
            ) ;
        }

        [Fact]
        public void searchWorks()
        {
            Assert.Equal(Menu.Entrees().Count(), Menu.Search(null, 1).Count());
            Assert.Empty(Menu.Search("asdf", 1));
            Assert.Single(Menu.Search("Burger", 1));

            Assert.Equal(Menu.Drinks().Count(), Menu.Search(null, 2).Count());
            Assert.Empty(Menu.Search("asdf", 2));
            Assert.Equal(3, Menu.Search("Coffee", 2).Count());

            Assert.Equal(Menu.Sides().Count(), Menu.Search(null, 3).Count());
            Assert.Empty(Menu.Search("asdf", 3));
            Assert.Equal(3, Menu.Search("Fries", 3).Count());
        }

        [Fact]
        public void priceFilterWorks()
        {
            Assert.Equal(Menu.Entrees().Count(), Menu.FilterByPrice(Menu.Entrees(), null, null).Count());
            Assert.Single(Menu.FilterByPrice(Menu.Entrees(), null, 5));
            Assert.Equal(6, Menu.FilterByPrice(Menu.Entrees(), 5, null).Count());
            Assert.Equal(5, Menu.FilterByPrice(Menu.Entrees(), 5, 8).Count());

            Assert.Equal(Menu.Drinks().Count(), Menu.FilterByPrice(Menu.Drinks(), null, null).Count());
            Assert.Equal(6, Menu.FilterByPrice(Menu.Drinks(), null, 1).Count());
            Assert.Equal(24, Menu.FilterByPrice(Menu.Drinks(), 1, null).Count());
            Assert.Equal(3, Menu.FilterByPrice(Menu.Drinks(), .5, 1).Count());

            Assert.Equal(Menu.Sides().Count(), Menu.FilterByPrice(Menu.Sides(), null, null).Count());
            Assert.Equal(4, Menu.FilterByPrice(Menu.Sides(), null, 1).Count());
            Assert.Equal(8, Menu.FilterByPrice(Menu.Sides(), 1, null).Count());
            Assert.Equal(3, Menu.FilterByPrice(Menu.Sides(), .5, 1).Count());
        }

        [Fact]
        public void calorieFilterWorks()
        {
            Assert.Equal(Menu.Entrees().Count(), Menu.FilterByPrice(Menu.Entrees(), null, null).Count());
            Assert.Single(Menu.FilterByPrice(Menu.Entrees(), null, 500));
            Assert.Equal(6, Menu.FilterByPrice(Menu.Entrees(), 500, null).Count());
            Assert.Equal(3, Menu.FilterByPrice(Menu.Entrees(), 500, 800).Count());

            Assert.Equal(Menu.Drinks().Count(), Menu.FilterByPrice(Menu.Drinks(), null, null).Count());
            Assert.Equal(7, Menu.FilterByPrice(Menu.Drinks(), null, 50).Count());
            Assert.Equal(23, Menu.FilterByPrice(Menu.Drinks(), 50, null).Count());
            Assert.Equal(4, Menu.FilterByPrice(Menu.Drinks(), 50, 100).Count());

            Assert.Equal(Menu.Sides().Count(), Menu.FilterByPrice(Menu.Sides(), null, null).Count());
            Assert.Equal(8, Menu.FilterByPrice(Menu.Sides(), null, 150).Count());
            Assert.Equal(4, Menu.FilterByPrice(Menu.Sides(), 150, null).Count());
            Assert.Equal(5, Menu.FilterByPrice(Menu.Sides(), 50, 100).Count());
        }
    }
}
