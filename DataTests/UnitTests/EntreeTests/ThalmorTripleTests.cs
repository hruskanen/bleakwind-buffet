/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.True(item.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Bun = false;
            Assert.False(item.Bun);
            item.Bun = true;
            Assert.True(item.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Ketchup = false;
            Assert.False(item.Ketchup);
            item.Ketchup = true;
            Assert.True(item.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Mustard = false;
            Assert.False(item.Mustard);
            item.Mustard = true;
            Assert.True(item.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Pickle = false;
            Assert.False(item.Pickle);
            item.Pickle = true;
            Assert.True(item.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Cheese = false;
            Assert.False(item.Cheese);
            item.Cheese = true;
            Assert.True(item.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Tomato = false;
            Assert.False(item.Tomato);
            item.Tomato = true;
            Assert.True(item.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Lettuce = false;
            Assert.False(item.Lettuce);
            item.Lettuce = true;
            Assert.True(item.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Mayo = false;
            Assert.False(item.Mayo);
            item.Mayo = true;
            Assert.True(item.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Bacon = false;
            Assert.False(item.Bacon);
            item.Bacon = true;
            Assert.True(item.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple item = new ThalmorTriple();
            item.Egg = false;
            Assert.False(item.Egg);
            item.Egg = true;
            Assert.True(item.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.Equal(8.32, item.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 943;
            ThalmorTriple item = new ThalmorTriple();
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard, bool includePickle, bool includeCheese, 
                                                           bool includeTomato, bool includeLettuce, bool includeMayo, bool includeBacon, bool includeEgg)
        {
            ThalmorTriple item = new ThalmorTriple()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg = includeEgg
            };
            if (!includeBun) Assert.Contains("Hold Bun", item.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold Ketchup", item.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold Mustard", item.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold Pickle", item.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold Cheese", item.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold Tomato", item.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold Lettuce", item.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold Mayo", item.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold Bacon", item.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold Egg", item.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && 
                includeLettuce && includeMayo && includeBacon && includeEgg) Assert.Empty(item.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }
    }
}