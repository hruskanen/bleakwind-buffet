﻿/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

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
        public void ChangingBunNotifiesBunProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = false; });
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bun = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bun = true; });
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
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = false; });
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ketchup = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ketchup = true; });
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
        public void ChangingMustardNotifiesMustardProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = false; });
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mustard = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mustard = true; });
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
        public void ChangingPickleNotifiesPickleProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = false; });
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pickle = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pickle = true; });
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
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = false; });
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Cheese = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Cheese = true; });
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
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = false; });
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Tomato = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Tomato = true; });
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
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Lettuce", () => { item.Lettuce = false; });
            Assert.PropertyChanged(item, "Lettuce", () => { item.Lettuce = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lettuce = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lettuce = true; });
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
        public void ChangingMayoNotifiesMayoProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Mayo", () => { item.Mayo = false; });
            Assert.PropertyChanged(item, "Mayo", () => { item.Mayo = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mayo = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mayo = true; });
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
        public void ChangingBaconNotifiesBaconProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Bacon", () => { item.Bacon = false; });
            Assert.PropertyChanged(item, "Bacon", () => { item.Bacon = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bacon = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bacon = true; });
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
        public void ChangingEggNotifiesEggnProperty()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Egg", () => { item.Egg = false; });
            Assert.PropertyChanged(item, "Egg", () => { item.Egg = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Egg = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Egg = true; });
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

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", item.description);
        }
    }
}