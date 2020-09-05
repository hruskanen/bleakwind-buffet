/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

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
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            item.Egg = false;
            Assert.False(item.Egg);
            item.Egg = true;
            Assert.True(item.Egg);
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
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            item.Pancake = false;
            Assert.False(item.Pancake);
            item.Pancake = true;
            Assert.True(item.Pancake);
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
    }
}