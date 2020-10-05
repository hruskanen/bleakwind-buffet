/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.True(item.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.True(item.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.True(item.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger item = new BriarheartBurger();
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.True(item.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger item = new BriarheartBurger();
            item.Bun = false;
            Assert.False(item.Bun);
            item.Bun = true;
            Assert.True(item.Bun);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = false; });
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger item = new BriarheartBurger();
            item.Ketchup = false;
            Assert.False(item.Ketchup);
            item.Ketchup = true;
            Assert.True(item.Ketchup);
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = false; });
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger item = new BriarheartBurger();
            item.Mustard = false;
            Assert.False(item.Mustard);
            item.Mustard = true;
            Assert.True(item.Mustard);
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = false; });
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger item = new BriarheartBurger();
            item.Pickle = false;
            Assert.False(item.Pickle);
            item.Pickle = true;
            Assert.True(item.Pickle);
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = false; });
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger item = new BriarheartBurger();
            item.Cheese = false;
            Assert.False(item.Cheese);
            item.Cheese = true;
            Assert.True(item.Cheese);
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = false; });
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = true; });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.Equal(6.32, item.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 743;
            BriarheartBurger item = new BriarheartBurger();
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger item = new BriarheartBurger()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese
            };
            if (!includeBun) Assert.Contains("Hold Bun", item.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold Ketchup", item.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold Mustard", item.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold Pickle", item.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold Cheese", item.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) Assert.Empty(item.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            BriarheartBurger item = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }
    }
}