/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone item = new ThugsTBone();
            Assert.Equal(6.44, item.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 982;
            ThugsTBone item = new ThugsTBone();
            Assert.Equal(cal, item.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone item = new ThugsTBone();
            Assert.Empty(item.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone item = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", item.ToString());
        }
    }
}