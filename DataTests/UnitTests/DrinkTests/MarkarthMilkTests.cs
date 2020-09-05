/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.False(item.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.Equal(Size.Small, item.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk item = new MarkarthMilk();
            item.Ice = true;
            Assert.True(item.Ice);
            item.Ice = false;
            Assert.False(item.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk item = new MarkarthMilk();
            item.Size = Size.Large;
            Assert.Equal(Size.Large, item.Size);
            item.Size = Size.Medium;
            Assert.Equal(Size.Medium, item.Size);
            item.Size = Size.Small;
            Assert.Equal(Size.Small, item.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk item = new MarkarthMilk() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(price, item.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk item = new MarkarthMilk() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk item = new MarkarthMilk() { Ice = includeIce };
            if (includeIce) Assert.Contains("Add Ice", item.SpecialInstructions);
            else Assert.Empty(item.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk item = new MarkarthMilk() { Size = size };
            Assert.Equal(name, item.ToString());
        }
    }
}