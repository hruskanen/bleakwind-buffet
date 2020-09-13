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
    }
}
