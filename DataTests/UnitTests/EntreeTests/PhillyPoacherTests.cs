/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.True(item.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.True(item.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.True(item.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher item = new PhillyPoacher();
            item.Sirloin = false;
            Assert.False(item.Sirloin);
            item.Sirloin = true;
            Assert.True(item.Sirloin);
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.PropertyChanged(item, "Sirloin", () => { item.Sirloin = false; });
            Assert.PropertyChanged(item, "Sirloin", () => { item.Sirloin = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Sirloin = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Sirloin = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher item = new PhillyPoacher();
            item.Onion = false;
            Assert.False(item.Onion);
            item.Onion = true;
            Assert.True(item.Onion);
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.PropertyChanged(item, "Onion", () => { item.Onion = false; });
            Assert.PropertyChanged(item, "Onion", () => { item.Onion = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Onion = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Onion = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher item = new PhillyPoacher();
            item.Roll = false;
            Assert.False(item.Roll);
            item.Roll = true;
            Assert.True(item.Roll);
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.PropertyChanged(item, "Roll", () => { item.Roll = false; });
            Assert.PropertyChanged(item, "Roll", () => { item.Roll = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Roll = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Roll = true; });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.Equal(7.23, item.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 784;
            PhillyPoacher item = new PhillyPoacher();
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher item = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            };
            if (!includeSirloin) Assert.Contains("Hold Sirloin", item.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold Onion", item.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold Roll", item.SpecialInstructions);
            if (includeSirloin && includeOnion && includeRoll) Assert.Empty(item.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.Equal("Philly Poacher", item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            PhillyPoacher item = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
    }
}