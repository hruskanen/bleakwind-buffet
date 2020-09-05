/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            Assert.False(item.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            Assert.False(item.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            Assert.False(item.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            Assert.Equal(Size.Small, item.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            item.Ice = true;
            Assert.True(item.Ice);
            item.Ice = false;
            Assert.False(item.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            item.Decaf = true;
            Assert.True(item.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            item.RoomForCream = true;
            Assert.True(item.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            item.Size = Size.Large;
            Assert.Equal(Size.Large, item.Size);
            item.Size = Size.Medium;
            Assert.Equal(Size.Medium, item.Size);
            item.Size = Size.Small;
            Assert.Equal(Size.Small, item.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee item = new CandlehearthCoffee() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(price, item.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee item = new CandlehearthCoffee() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee item = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream
            };

            if (includeIce) Assert.Contains("Add Ice", item.SpecialInstructions);
            if (includeCream) Assert.Contains("Add Cream", item.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Empty(item.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee item = new CandlehearthCoffee()
            {
                Size = size,
                Decaf = decaf
            };
            Assert.Equal(name, item.ToString());
        }
    }
}
