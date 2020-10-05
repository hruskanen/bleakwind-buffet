/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.True(item.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.True(item.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.True(item.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.True(item.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            item.Broccoli = false;
            Assert.False(item.Broccoli);
            item.Broccoli = true;
            Assert.True(item.Broccoli);
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.PropertyChanged(item, "Broccoli", () => { item.Broccoli = false; });
            Assert.PropertyChanged(item, "Broccoli", () => { item.Broccoli = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            item.Mushrooms = false;
            Assert.False(item.Mushrooms);
            item.Mushrooms = true;
            Assert.True(item.Mushrooms);
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.PropertyChanged(item, "Mushrooms", () => { item.Mushrooms = false; });
            Assert.PropertyChanged(item, "Mushrooms", () => { item.Mushrooms = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            item.Tomato = false;
            Assert.False(item.Tomato);
            item.Tomato = true;
            Assert.True(item.Tomato);
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = false; });
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = true; });
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            item.Cheddar = false;
            Assert.False(item.Cheddar);
            item.Cheddar = true;
            Assert.True(item.Cheddar);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.PropertyChanged(item, "Cheddar", () => { item.Cheddar = false; });
            Assert.PropertyChanged(item, "Cheddar", () => { item.Cheddar = true; });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.Equal(4.57, item.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 404;
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.Equal(cal, item.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette item = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar,
            };
            if (!includeBroccoli) Assert.Contains("Hold Broccoli", item.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold Mushrooms", item.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold Tomato", item.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold Cheddar", item.SpecialInstructions);
            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar) Assert.Empty(item.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", item.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }
    }
}