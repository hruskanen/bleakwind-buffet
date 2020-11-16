/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda item = new SailorSoda();
            Assert.True(item.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda item = new SailorSoda();
            Assert.Equal(Size.Small, item.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda item = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, item.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda item = new SailorSoda();
            item.Ice = false;
            Assert.False(item.Ice);
            item.Ice = true;
            Assert.True(item.Ice);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            SailorSoda item = new SailorSoda();
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = false; });
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda item = new SailorSoda();
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
            SailorSoda item = new SailorSoda();
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
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda item = new SailorSoda();
            item.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, item.Flavor);
            item.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, item.Flavor);
            item.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, item.Flavor);
            item.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, item.Flavor);
            item.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, item.Flavor);
            item.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, item.Flavor);
        }

        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            SailorSoda item = new SailorSoda();
            Assert.PropertyChanged(item, "Flavor", () => { item.Flavor = SodaFlavor.Blackberry; });
            Assert.PropertyChanged(item, "Flavor", () => { item.Flavor = SodaFlavor.Cherry; });
            Assert.PropertyChanged(item, "Flavor", () => { item.Flavor = SodaFlavor.Grapefruit; });
            Assert.PropertyChanged(item, "Flavor", () => { item.Flavor = SodaFlavor.Lemon; });
            Assert.PropertyChanged(item, "Flavor", () => { item.Flavor = SodaFlavor.Peach; });
            Assert.PropertyChanged(item, "Flavor", () => { item.Flavor = SodaFlavor.Watermelon; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Flavor = SodaFlavor.Blackberry; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Flavor = SodaFlavor.Cherry; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Flavor = SodaFlavor.Grapefruit; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Flavor = SodaFlavor.Lemon; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Flavor = SodaFlavor.Peach; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Flavor = SodaFlavor.Watermelon; });
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda item = new SailorSoda() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(price, item.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda item = new SailorSoda() { Size = size };
            Assert.Equal(size, item.Size);
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda item = new SailorSoda() { Ice = includeIce };
            if (!includeIce) Assert.Contains("Hold Ice", item.SpecialInstructions);
            else Assert.Empty(item.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda item = new SailorSoda()
            {
                Flavor = flavor,
                Size = size
            };
            Assert.Equal(name, item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            SailorSoda item = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            SailorSoda item = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            SailorSoda item = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            SailorSoda item = new SailorSoda();
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", item.description);
        }
    }
}
