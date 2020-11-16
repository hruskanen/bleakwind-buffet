/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

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
        public void ChangingIceNotifiesIceProperty()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = true; });
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = false; });
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

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MarkarthMilk item = new MarkarthMilk();
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

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.Equal("Hormone-free organic 2% milk.", item.description);
        }
    }
}