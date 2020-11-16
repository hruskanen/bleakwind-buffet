/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak item = new FriedMiraak();
            Assert.Equal(Size.Small, item.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak item = new FriedMiraak();
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
            FriedMiraak item = new FriedMiraak();
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

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak item = new FriedMiraak();
            Assert.Empty(item.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak item = new FriedMiraak() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(price, item.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak item = new FriedMiraak() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(calories, item.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak item = new FriedMiraak() { Size = size };
            Assert.Equal(name, item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            FriedMiraak item = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            FriedMiraak item = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            FriedMiraak item = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            FriedMiraak item = new FriedMiraak();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            FriedMiraak item = new FriedMiraak();
            Assert.Equal("Perfectly prepared hash brown pancakes.", item.description);
        }
    }
}