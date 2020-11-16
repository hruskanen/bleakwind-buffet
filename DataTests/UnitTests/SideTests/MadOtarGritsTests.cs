/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits item = new MadOtarGrits();
            Assert.Equal(Size.Small, item.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits item = new MadOtarGrits();
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
            MadOtarGrits item = new MadOtarGrits();
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
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits item = new MadOtarGrits();
            Assert.Empty(item.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits item = new MadOtarGrits() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(price, item.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits item = new MadOtarGrits() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(calories, item.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits item = new MadOtarGrits() { Size = size };
            Assert.Equal(name, item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            MadOtarGrits item = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            MadOtarGrits item = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            MadOtarGrits item = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            MadOtarGrits item = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            MadOtarGrits item = new MadOtarGrits();
            Assert.Equal("Cheesey Grits.", item.description);
        }
    }
}