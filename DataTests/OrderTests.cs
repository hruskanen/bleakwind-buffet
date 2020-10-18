/*
 * Author: Hunter Ruskanen
 * Class: OrderTests.cs
 * Purpose: Test the Menu.cs class in the Data library
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

namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        List<IOrderItem> fullMenu = new List<IOrderItem>()
        {
            new AretinoAppleJuice(),
            new CandlehearthCoffee(),
            new MarkarthMilk(),
            new SailorSoda(),
            new WarriorWater(),
            new BriarheartBurger(),
            new DoubleDraugr(),
            new GardenOrcOmelette(),
            new PhillyPoacher(),
            new SmokehouseSkeleton(),
            new ThalmorTriple(),
            new ThugsTBone(),
            new DragonbornWaffleFries(),
            new FriedMiraak(),
            new MadOtarGrits(),
            new VokunSalad()
        };

        [Fact]
        public void ShouldBeAssignableToAbstractObservableCollection()
        {
            Order order = new Order(new OrderComponent());
            Assert.IsAssignableFrom<ObservableCollection<object>>(order);
        }

        [Fact]
        public void listShouldBeEmptyByDefault()
        {
            Order order = new Order(new OrderComponent());
            Assert.Empty(order.orders);
        }

        [Fact]
        public void listGrowsWhenAddingAnItem()
        {
            Order order = new Order(new OrderComponent());
            for(int i = 0; i < fullMenu.Count; i++)
            {
                order.Add(fullMenu[i]);
                Assert.Equal(order.orders.Count, i + 1);
            }
        }

        [Fact]
        public void listShrinkWhenRemovingAnItem()
        {
            Order order = new Order(new OrderComponent());
            for (int i = 0; i < fullMenu.Count; i++)
            {
                order.Add(fullMenu[i]);
                order.Remove(fullMenu[i].Price, fullMenu[i].Calories);
                Assert.Empty(order.orders);
            }
        }

        [Fact]
        public void listStaysWhenChangingAnItem()
        {
            Order order = new Order(new OrderComponent());
            for (int i = 0; i < fullMenu.Count; i++)
            {
                order.Add(fullMenu[i]);
                order.Change(fullMenu[i], fullMenu[i].Price, fullMenu[i].Calories);
                Assert.Equal(order.orders.Count, i + 1);
            }
        }

        [Fact]
        public void totalsChangeWhenAddingAnItem()
        {
            Order order = new Order(new OrderComponent());
            for (int i = 0; i < fullMenu.Count; i++)
            {
                order.Add(fullMenu[i]);
                order.Change(fullMenu[i], fullMenu[i].Price, fullMenu[i].Calories);
                Assert.Equal(order._subTotal, fullMenu[i].Price);
                Assert.Equal(order._tax, fullMenu[i].Price * .12);
                Assert.Equal(order._total, fullMenu[i].Price + fullMenu[i].Price * .12);
                order.Remove(fullMenu[i].Price, fullMenu[i].Calories);
            }
        }

        [Fact]
        public void addingNotifysFiveThing()
        {
            Order order = new Order(new OrderComponent());
            for (int i = 0; i < fullMenu.Count; i++)
            {
                Assert.PropertyChanged(order, "orders", () => { order.Add(fullMenu[i]); });
                Assert.PropertyChanged(order, "_subTotal", () => { order.Add(fullMenu[i]); });
                Assert.PropertyChanged(order, "_tax", () => { order.Add(fullMenu[i]); });
                Assert.PropertyChanged(order, "_total", () => { order.Add(fullMenu[i]); });
                Assert.PropertyChanged(order, "_totalCalories", () => { order.Add(fullMenu[i]); });
            }
        }

        [Fact]
        public void removingNotifysFiveThing()
        {
            Order order = new Order(new OrderComponent());
            for (int i = 0; i < fullMenu.Count; i++)
            {
                order.Add(fullMenu[i]);
                Assert.PropertyChanged(order, "orders", () => { order.Remove(fullMenu[i]); });
                order.Add(fullMenu[i]);
                Assert.PropertyChanged(order, "_subTotal", () => { order.Remove(fullMenu[i]); });
                order.Add(fullMenu[i]);
                Assert.PropertyChanged(order, "_tax", () => { order.Remove(fullMenu[i]); });
                order.Add(fullMenu[i]);
                Assert.PropertyChanged(order, "_total", () => { order.Remove(fullMenu[i]); });
                order.Add(fullMenu[i]);
                Assert.PropertyChanged(order, "_totalCalories", () => { order.Remove(fullMenu[i]); });
            }
        }
    }
}
