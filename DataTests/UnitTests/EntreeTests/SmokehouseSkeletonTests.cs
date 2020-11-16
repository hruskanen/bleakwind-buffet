/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.True(item.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.True(item.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.True(item.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.True(item.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            item.SausageLink = false;
            Assert.False(item.SausageLink);
            item.SausageLink = true;
            Assert.True(item.SausageLink);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "SausageLink", () => { item.SausageLink = false; });
            Assert.PropertyChanged(item, "SausageLink", () => { item.SausageLink = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.SausageLink = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.SausageLink = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            item.Egg = false;
            Assert.False(item.Egg);
            item.Egg = true;
            Assert.True(item.Egg);
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "Egg", () => { item.Egg = false; });
            Assert.PropertyChanged(item, "Egg", () => { item.Egg = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Egg = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Egg = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            item.HashBrowns = false;
            Assert.False(item.HashBrowns);
            item.HashBrowns = true;
            Assert.True(item.HashBrowns);
        }

        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "HashBrowns", () => { item.HashBrowns = false; });
            Assert.PropertyChanged(item, "HashBrowns", () => { item.HashBrowns = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.HashBrowns = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.HashBrowns = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            item.Pancake = false;
            Assert.False(item.Pancake);
            item.Pancake = true;
            Assert.True(item.Pancake);
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "Pancake", () => { item.Pancake = false; });
            Assert.PropertyChanged(item, "Pancake", () => { item.Pancake = true; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pancake = false; });
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pancake = true; });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.Equal(5.62, item.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 602;
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };
            if (!includeSausage) Assert.Contains("Hold Sausage Link", item.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold Egg", item.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold HashBrowns", item.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold Pancake", item.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(item.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedClass()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ShouldReturnDescription()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", item.description);
        }
    }
}