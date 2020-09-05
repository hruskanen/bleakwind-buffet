/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.True(item.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Bun = false;
            Assert.False(item.Bun);
            item.Bun = true;
            Assert.True(item.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Ketchup = false;
            Assert.False(item.Ketchup);
            item.Ketchup = true;
            Assert.True(item.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Mustard = false;
            Assert.False(item.Mustard);
            item.Mustard = true;
            Assert.True(item.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Pickle = false;
            Assert.False(item.Pickle);
            item.Pickle = true;
            Assert.True(item.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Cheese = false;
            Assert.False(item.Cheese);
            item.Cheese = true;
            Assert.True(item.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Tomato = false;
            Assert.False(item.Tomato);
            item.Tomato = true;
            Assert.True(item.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Lettuce = false;
            Assert.False(item.Lettuce);
            item.Lettuce = true;
            Assert.True(item.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr item = new DoubleDraugr();
            item.Mayo = false;
            Assert.False(item.Mayo);
            item.Mayo = true;
            Assert.True(item.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.Equal(7.32, item.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 843;
            DoubleDraugr item = new DoubleDraugr();
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr item = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };
            if (!includeBun) Assert.Contains("Hold Bun", item.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold Ketchup", item.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold Mustard", item.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold Pickle", item.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold Cheese", item.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold Tomato", item.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold Lettuce", item.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold Mayo", item.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && 
                includeCheese && includeTomato && includeLettuce && includeMayo) Assert.Empty(item.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.Equal("Double Draugr", item.ToString());
        }
    }
}