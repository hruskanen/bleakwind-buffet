/*
 * Author: Hunter Ruskanen
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater item = new WarriorWater();
            Assert.True(item.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater item = new WarriorWater();
            Assert.False(item.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater item = new WarriorWater();
            Assert.Equal(Size.Small, item.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater item = new WarriorWater();
            item.Ice = true;
            Assert.True(item.Ice);
            item.Ice = false;
            Assert.False(item.Ice);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            WarriorWater item = new WarriorWater();
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = false; });
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater item = new WarriorWater();
            item.Lemon = true;
            Assert.True(item.Lemon);
            item.Lemon = false;
            Assert.False(item.Lemon);
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            WarriorWater item = new WarriorWater();
            Assert.PropertyChanged(item, "Lemon", () => { item.Lemon = true; });
            Assert.PropertyChanged(item, "Lemon", () => { item.Lemon = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lemon = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lemon = false; });
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater item = new WarriorWater();
            item.Size = Size.Large;
            Assert.Equal(Size.Large, item.Size);
            item.Size = Size.Medium;
            Assert.Equal(Size.Medium, item.Size);
            item.Size = Size.Small;
            Assert.Equal(Size.Small, item.Size);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            WarriorWater item = new WarriorWater();
            Assert.PropertyChanged(item, "Size", () => { item.Size = Size.Large; });
            Assert.PropertyChanged(item, "Size", () => { item.Size = Size.Medium; });
            Assert.PropertyChanged(item, "Size", () => { item.Size = Size.Small; });
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Large; });
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Medium; });
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Small; });
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Large; });
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Medium; });
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Small; });
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater item = new WarriorWater() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(price, item.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater item = new WarriorWater() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater item = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };
            if (!includeIce) Assert.Contains("Hold Ice", item.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add Lemon", item.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Empty(item.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater item = new WarriorWater() { Size = size };
            Assert.Equal(name, item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            WarriorWater item = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            WarriorWater item = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            WarriorWater item = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            WarriorWater item = new WarriorWater();
            Assert.Equal("It’s water. Just water.", item.description);
        }
    }
}