/*
 * Author: Hunter Ruskanen
 * Class: ComboTests.cs
 * Purpose: Test the Combo.xaml.cs class in the Data library
 */
using Xunit;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using PointOfSale;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests
{
    public class ComboTests
    {
        List<IOrderItem> entreeMenu = new List<IOrderItem>()
        {
            new BriarheartBurger(),
            new DoubleDraugr(),
            new GardenOrcOmelette(),
            new PhillyPoacher(),
            new SmokehouseSkeleton(),
            new ThalmorTriple(),
            new ThugsTBone()
        };
        List<IOrderItem> drinkMenu = new List<IOrderItem>()
        {
            new AretinoAppleJuice(),
            new CandlehearthCoffee(),
            new MarkarthMilk(),
            new SailorSoda(),
            new WarriorWater()
        };
        List<IOrderItem> sideMenu = new List<IOrderItem>()
        {
            new DragonbornWaffleFries(),
            new FriedMiraak(),
            new MadOtarGrits(),
            new VokunSalad()
        };

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Order order = new Order(new OrderComponent());
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ComboShouldBeEmptyByDefault()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            Assert.Null(combo.comboEntree);
            Assert.Null(combo.comboDrink);
            Assert.Null(combo.comboSide);
            Assert.True(combo.newCombo);
        }

        [Fact]
        public void ComboCanBeNotEmpty()
        {
            foreach (IOrderItem entree in entreeMenu)
            {
                foreach (IOrderItem drink in drinkMenu)
                {
                    foreach (IOrderItem side in sideMenu)
                    {
                        Combo combo = new Combo(new Order(new OrderComponent()), entree, drink, side);
                        Assert.NotNull(combo.comboEntree);
                        Assert.NotNull(combo.comboDrink);
                        Assert.NotNull(combo.comboSide);
                        Assert.False(combo.newCombo);
                    }
                }
            }
        }

        [Fact]
        public void AddingAnEntreeWorks()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < entreeMenu.Count; i++)
            {
                combo.addItem(entreeMenu[i], 1);
                Assert.Equal(combo.comboEntree, entreeMenu[i]);
            }
        }

        [Fact]
        public void AddingAnDrinkWorks()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < drinkMenu.Count; i++)
            {
                combo.addItem(drinkMenu[i], 2);
                Assert.Equal(combo.comboDrink, drinkMenu[i]);
            }
        }

        [Fact]
        public void AddingAnSideWorks()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < sideMenu.Count; i++)
            {
                combo.addItem(sideMenu[i], 3);
                Assert.Equal(combo.comboSide, sideMenu[i]);
            }
        }

        [Fact]
        public void AddingAnEntreeNotifyFourThings()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < entreeMenu.Count; i++)
            {
                Assert.PropertyChanged(combo, "Price", () => { combo.addItem(entreeMenu[i], 1); });
                Assert.PropertyChanged(combo, "_totalCalories", () => { combo.addItem(entreeMenu[i], 1); });
                Assert.PropertyChanged(combo, "comboEntree", () => { combo.addItem(entreeMenu[i], 1); });
                Assert.PropertyChanged(combo, "entreeName", () => { combo.addItem(entreeMenu[i], 1); });
            }
        }

        [Fact]
        public void AddingAnDrinkNotifyFourThings()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < drinkMenu.Count; i++)
            {
                Assert.PropertyChanged(combo, "Price", () => { combo.addItem(drinkMenu[i], 2); });
                Assert.PropertyChanged(combo, "_totalCalories", () => { combo.addItem(drinkMenu[i], 2); });
                Assert.PropertyChanged(combo, "comboDrink", () => { combo.addItem(drinkMenu[i], 2); });
                Assert.PropertyChanged(combo, "drinkName", () => { combo.addItem(drinkMenu[i], 2); });
            }
        }

        [Fact]
        public void AddingAnSideNotifyFourThings()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < sideMenu.Count; i++)
            {
                Assert.PropertyChanged(combo, "Price", () => { combo.addItem(sideMenu[i], 3); });
                Assert.PropertyChanged(combo, "_totalCalories", () => { combo.addItem(sideMenu[i], 3); });
                Assert.PropertyChanged(combo, "comboSide", () => { combo.addItem(sideMenu[i], 3); });
                Assert.PropertyChanged(combo, "sideName", () => { combo.addItem(sideMenu[i], 3); });
            }
        }

        [Fact]
        public void RemovingAnEntreeWorks()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < entreeMenu.Count; i++)
            {
                combo.addItem(entreeMenu[i], 1);
                combo.removeItem(1, entreeMenu[i].Price, entreeMenu[i].Calories);
                Assert.Null(combo.comboEntree);
            }
        }

        [Fact]
        public void RemovingAnDrinkWorks()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < drinkMenu.Count; i++)
            {
                combo.addItem(drinkMenu[i], 2);
                combo.removeItem(2, drinkMenu[i].Price, drinkMenu[i].Calories);
                Assert.Null(combo.comboDrink);
            }
        }

        [Fact]
        public void RemovingAnSideWorks()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < sideMenu.Count; i++)
            {
                combo.addItem(sideMenu[i], 3);
                combo.removeItem(3, sideMenu[i].Price, sideMenu[i].Calories);
                Assert.Null(combo.comboSide);
            }
        }

        [Fact]
        public void RemovingAnEntreeNotifyFourThings()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < entreeMenu.Count; i++)
            {
                combo.addItem(entreeMenu[i], 1);
                Assert.PropertyChanged(combo, "Price", () => { combo.removeItem(1, entreeMenu[i].Price, entreeMenu[i].Calories); });
                combo.addItem(entreeMenu[i], 1);
                Assert.PropertyChanged(combo, "_totalCalories", () => { combo.removeItem(1, entreeMenu[i].Price, entreeMenu[i].Calories); });
                combo.addItem(entreeMenu[i], 1);
                Assert.PropertyChanged(combo, "comboEntree", () => { combo.removeItem(1, entreeMenu[i].Price, entreeMenu[i].Calories); });
                combo.addItem(entreeMenu[i], 1);
                Assert.PropertyChanged(combo, "entreeName", () => { combo.removeItem(1, entreeMenu[i].Price, entreeMenu[i].Calories); });
            }
        }

        [Fact]
        public void RemovingAnDrinkNotifyFourThings()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < drinkMenu.Count; i++)
            {
                combo.addItem(drinkMenu[i], 2);
                Assert.PropertyChanged(combo, "Price", () => { combo.removeItem(2, drinkMenu[i].Price, drinkMenu[i].Calories); });
                combo.addItem(drinkMenu[i], 2);
                Assert.PropertyChanged(combo, "_totalCalories", () => { combo.removeItem(2, drinkMenu[i].Price, drinkMenu[i].Calories); });
                combo.addItem(drinkMenu[i], 2);
                Assert.PropertyChanged(combo, "comboEntree", () => { combo.removeItem(2, drinkMenu[i].Price, drinkMenu[i].Calories); });
                combo.addItem(drinkMenu[i], 2);
                Assert.PropertyChanged(combo, "entreeName", () => { combo.removeItem(2, drinkMenu[i].Price, drinkMenu[i].Calories); });
            }
        }

        [Fact]
        public void RemovingAnSideNotifyFourThings()
        {
            Combo combo = new Combo(new Order(new OrderComponent()), null, null, null);
            for (int i = 0; i < sideMenu.Count; i++)
            {
                combo.addItem(sideMenu[i], 3);
                Assert.PropertyChanged(combo, "Price", () => { combo.removeItem(3, sideMenu[i].Price, sideMenu[i].Calories); });
                combo.addItem(sideMenu[i], 3);
                Assert.PropertyChanged(combo, "_totalCalories", () => { combo.removeItem(3, sideMenu[i].Price, sideMenu[i].Calories); });
                combo.addItem(sideMenu[i], 3);
                Assert.PropertyChanged(combo, "comboEntree", () => { combo.removeItem(3, sideMenu[i].Price, sideMenu[i].Calories); });
                combo.addItem(sideMenu[i], 3);
                Assert.PropertyChanged(combo, "entreeName", () => { combo.removeItem(3, sideMenu[i].Price, sideMenu[i].Calories); });
            }
        }

        [Fact]
        public void ToStringOverrided()
        {
            foreach (IOrderItem entree in entreeMenu)
            {
                foreach (IOrderItem drink in drinkMenu)
                {
                    foreach (IOrderItem side in sideMenu)
                    {
                        Combo combo = new Combo(new Order(new OrderComponent()), entree, drink, side);
                        Assert.Equal("Combo", combo.ToString());
                    }
                }
            }
        }

        [Fact]
        public void SpecialInstructionsShouldBeEmptyWhenNoItemsAreChanged()
        {
            foreach (IOrderItem entree in entreeMenu)
            {
                foreach (IOrderItem drink in drinkMenu)
                {
                    foreach (IOrderItem side in sideMenu)
                    {
                        List<string> temp = new List<string>();
                        temp.Add(entree.ToString());
                        temp.Add(drink.ToString());
                        temp.Add(side.ToString());
                        Combo combo = new Combo(new Order(new OrderComponent()), entree, drink, side);
                        Assert.Equal(temp, combo.SpecialInstructions);
                    }
                }
            }
        }
    }
}
