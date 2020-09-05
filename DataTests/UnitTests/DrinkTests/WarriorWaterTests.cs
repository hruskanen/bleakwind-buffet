/*
 * Author: Hunter Ruskanen
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

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
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater item = new WarriorWater();
            item.Lemon = true;
            Assert.True(item.Lemon);
            item.Lemon = false;
            Assert.False(item.Lemon);
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
    }
}