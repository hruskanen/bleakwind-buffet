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
            order.Add(new BriarheartBurger());
            Assert.Single(order.orders);
        }

        [Fact]
        public void listShrinkWhenRemovingAnItem()
        {
            Order order = new Order(new OrderComponent());
            BriarheartBurger item = new BriarheartBurger();
            order.Add(item);
            order.Remove(item.Price, item.Calories);
            Assert.Empty(order.orders);
        }

        [Fact]
        public void listStaysWhenChangingAnItem()
        {
            Order order = new Order(new OrderComponent());
            BriarheartBurger item = new BriarheartBurger();
            order.Add(new BriarheartBurger());
            order.Change(item, item.Price, item.Calories);
            order.Remove(item.Price, item.Calories);
            Assert.Empty(order.orders);
        }

        [Fact]
        public void totalsChangeWhenAddingAnItem()
        {
            Order order = new Order(new OrderComponent());
            BriarheartBurger item = new BriarheartBurger();
            order.Add(item);
            Assert.Equal(order._subTotal, item.Price);
            Assert.Equal(order._tax, item.Price * .12);
            Assert.Equal(order._total, item.Price + item.Price * .12);
        }

        [Fact]
        public void addingNotifysFourThing()
        {
            Order order = new Order(new OrderComponent());
            BriarheartBurger item = new BriarheartBurger();
            Assert.PropertyChanged(item, "_subTotal", () => { order.Add(item); });
            Assert.PropertyChanged(item, "_tax", () => { order.Add(item); });
            Assert.PropertyChanged(item, "_total", () => { order.Add(item); });
            Assert.PropertyChanged(item, "_totalCalories", () => { order.Add(item); });
        }

        [Fact]
        public void removingNotifysFourThing()
        {
            Order order = new Order(new OrderComponent());
            BriarheartBurger item = new BriarheartBurger();
            Assert.PropertyChanged(item, "_subTotal", () => { order.Add(item); });
            Assert.PropertyChanged(item, "_tax", () => { order.Add(item); });
            Assert.PropertyChanged(item, "_total", () => { order.Add(item); });
            Assert.PropertyChanged(item, "_totalCalories", () => { order.Add(item); });
        }
        



    }
}
