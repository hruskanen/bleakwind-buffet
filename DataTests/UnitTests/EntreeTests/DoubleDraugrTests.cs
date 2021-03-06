﻿/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

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
        public void ChangingBunNotifiesBunProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = false; });
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bun = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bun = true; });
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
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = false; });
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ketchup = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ketchup = true; });
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
        public void ChangingMustardNotifiesMustardProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = false; });
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mustard = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mustard = true; });
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
        public void ChangingPickleNotifiesPickleProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = false; });
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pickle = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pickle = true; });
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
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = false; });
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Cheese = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Cheese = true; });
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
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = false; });
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Tomato = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Tomato = true; });
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
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Lettuce", () => { item.Lettuce = false; });
            Assert.PropertyChanged(item, "Lettuce", () => { item.Lettuce = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lettuce = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lettuce = true; });
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
        public void ChangingMayoNotifiesMayoProperty()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.PropertyChanged(item, "Mayo", () => { item.Mayo = false; });
            Assert.PropertyChanged(item, "Mayo", () => { item.Mayo = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mayo = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mayo = true; });
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

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            DoubleDraugr item = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", item.description);
        }
    }
}