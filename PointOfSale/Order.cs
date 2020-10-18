/* Hunter Ruskanen
 * OrderComponent.xaml.cs
 * The base of the Order
*/

using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Collections;
using System.Collections.ObjectModel;

namespace PointOfSale
{
    public class Order : ObservableCollection<object>
    {
        public int currentListIndex = 0;

        /// <summary>
        /// the list of items and combos
        /// </summary>
        private ObservableCollection<object> Orders = new ObservableCollection<object>();
        public ObservableCollection<object> orders
        {
            get { return Orders; }
            set
            {
                if (Orders != value)
                {
                    Orders = value;
                    NotifyPropertyChanged("orders");
                }
            }
        }

        /// <summary>
        /// the order number
        /// </summary>
        private int _OrderNumber = 1;
        public int _orderNumber
        {
            get { return _OrderNumber; }
            set
            {
                if (_OrderNumber != value)
                {
                    _OrderNumber = value;
                    NotifyPropertyChanged("_orderNumber");
                }
            }
        }

        /// <summary>
        /// the curent subtotal for the combo
        /// </summary>
        private double _SubTotal = 0;
        public double _subTotal
        {
            get { return _SubTotal; }
            set
            {
                if (_SubTotal != value)
                {
                    _SubTotal = value;
                    _tax = value * .12;
                    _total = Math.Round(value + (value * .12), 2, MidpointRounding.AwayFromZero);
                    NotifyPropertyChanged("_subTotal");
                }
            }
        }

        /// <summary>
        /// the curent tax for the combo
        /// </summary>
        private double _Tax;
        public double _tax
        {
            get { return _Tax; }
            set
            {
                if (_Tax != value)
                {
                    _Tax = value;
                    NotifyPropertyChanged("_tax");
                }
            }
        }

        /// <summary>
        /// the curent total for the combo
        /// </summary>
        private double _Total;
        public double _total
        {
            get { return _Total; }
            set
            {
                if (_Total != value)
                {
                    _Total = value;
                    NotifyPropertyChanged("_total");
                }
            }
        }

        /// <summary>
        /// the curent calories for the combo
        /// </summary>
        private uint _TotalCalories = 0;
        public uint _totalCalories
        {
            get { return _TotalCalories; }
            set
            {
                if (_TotalCalories != value)
                {
                    _TotalCalories = value;
                    NotifyPropertyChanged("_totalCalories");
                }
            }
        }

        /// <summary>
        /// the access to the perent
        /// </summary>
        public OrderComponent parent;


        /// <summary>
        /// the constructor
        /// </summary>
        /// <param name="orderComponent"></param>
        public Order(OrderComponent orderComponent)
        {
            this.parent = orderComponent;
            orders.CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// listener for collection change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("_subTotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("_tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("_total"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:

                    foreach (object item in e.NewItems)
                    {
                        PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (object item in e.OldItems)
                    {
                        PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
            }
        }

        /// <summary>
        /// changes the count as needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("orders"));
        }

        /// <summary>
        /// adds items to the order
        /// </summary>
        /// <param name="item"> the item being added</param>
        public void Add(IOrderItem item)
        {
            currentListIndex = orders.Count;
            parent.SendButt.IsEnabled = false;
            orders.Add(item);
            _subTotal += item.Price;
            _totalCalories += item.Calories;
            NotifyPropertyChanged("_subTotal");
            NotifyPropertyChanged("_tax");
            NotifyPropertyChanged("_total");
            NotifyPropertyChanged("_totalCalories");
            parent.swapScreens();
        }

        /// <summary>
        /// removes an item from the the order
        /// </summary>
        /// <param name="orgPrice"> the orignal price for the item</param>
        /// <param name="orgCalories"> the orignal calories for the item </param>
        public void Remove(double orgPrice, uint orgCalories)
        {
            _subTotal -= orgPrice;
            _totalCalories -= orgCalories;
            NotifyPropertyChanged("_subTotal");
            NotifyPropertyChanged("_tax");
            NotifyPropertyChanged("_total");
            NotifyPropertyChanged("_totalCalories");
            orders.RemoveAt(currentListIndex);

            parent.showMenu();
        }

        /// <summary>
        /// makes the selected item on the list the current index and calls swapScreens
        /// </summary>
        public void Change(IOrderItem item, double orgPrice, uint orgCalories)
        {
            orders[currentListIndex] = item;
            if (item.Price != orgPrice)
            {
                _subTotal -= orgPrice;
                _subTotal += item.Price;
                NotifyPropertyChanged("_subTotal");
                NotifyPropertyChanged("_tax");
                NotifyPropertyChanged("_total");
            }
            if (item.Calories != orgCalories)
            {
                _totalCalories -= orgCalories;
                _totalCalories += item.Calories;
                NotifyPropertyChanged("_totalCalories");
            }

            parent.showMenu();
        }

        /// <summary>
        /// resets the order
        /// </summary>
        public void resetOrder()
        {
            _subTotal = 0;
            _orderNumber++;
            orders.Clear();
            parent.showMenu();
        }

        /// <summary>
        /// adds the new combo to the list
        /// </summary>
        /// <param name="comboEntree"> combos entree </param>
        /// <param name="comboDrink"> combos drink </param>
        /// <param name="comboSide"> combos side </param>
        /// <param name="_comboTotal"> combos total price </param>
        /// <param name="_comboCalories"> combos total calories </param>
        /// <param name="orgPrice"> combos original price </param>
        /// <param name="orgCalories"> combos original calories </param>
        /// <param name="newCombo"> is this was a new combo or not </param>
        public void createCombo(IOrderItem comboEntree, IOrderItem comboDrink, IOrderItem comboSide, double _comboTotal, uint _comboCalories, double orgPrice, uint orgCalories, bool newCombo)
        {
            Combo combo = new Combo(this, comboEntree, comboDrink, comboSide);
            if (newCombo)
            {
                _subTotal += _comboTotal;
                _totalCalories += _comboCalories;
                orders.Add(combo);
            }
            else
            {
                _subTotal -= _comboTotal;
                _subTotal += orgPrice;
                _totalCalories -= orgCalories;
                _totalCalories += _comboCalories;
                orders[currentListIndex] = combo;
            }

            parent.showMenu();
        }

        /// <summary>
        /// remove a combo from the list
        /// </summary>
        public void removeCombo(double orgPrice, uint orgCalories, bool newCombo)
        {
            if(!newCombo)
            {
                _subTotal -= orgPrice;
                _totalCalories -= orgCalories;
                orders.RemoveAt(currentListIndex);
            }
            parent.showMenu();
        }


        /// <summary>
        ///  porpert changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected override event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
