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
    public class Order : ObservableCollection<IOrderItem>
    {
        public int currentListIndex = 0;


        private ObservableCollection<IOrderItem> Orders = new ObservableCollection<IOrderItem>();
        public ObservableCollection<IOrderItem> orders
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
                    _total = value + (value * .12);
                    NotifyPropertyChanged("_subTotal");
                }
            }
        }

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


        public OrderComponent parent;

        public Order(OrderComponent orderComponent)
        {
            this.parent = orderComponent;
            orders.CollectionChanged += CollectionChangedListener;

        }

        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("_subTotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("_tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("_total"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
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


        public new void Add(IOrderItem item)
        {
            currentListIndex = orders.Count;
            parent.CancelButt.IsEnabled = false;
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
            
        public void Remove(double orgPrice, uint orgCalories)
        {
            _subTotal -= orgPrice;
            _totalCalories -= orgCalories;
            NotifyPropertyChanged("_subTotal");
            NotifyPropertyChanged("_tax");
            NotifyPropertyChanged("_total");
            NotifyPropertyChanged("_totalCalories");
            orders.RemoveAt(currentListIndex);
            parent.CancelButt.IsEnabled = true;
            parent.SendButt.IsEnabled = true;

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
            parent.CancelButt.IsEnabled = true;
            parent.SendButt.IsEnabled = true;

            parent.showMenu();
        }

        /// <summary>
        /// Sends the current order and clears the order list
        /// </summary>
        public void sendOrder()
        {
            //Send order.Items here

            _subTotal = 0;
            _orderNumber++;
            orders.Clear();
            MessageBox.Show("Order Sent", "Sent");
            parent.showMenu();
            //didn't know where to send it so the comment and meesage box and a place holder
        }

        /// <summary>
        /// Cancles the current order and clears the order list
        /// </summary>
        public void cancelOrder()
        {
            _subTotal = 0;
            orders.Clear();
            MessageBox.Show("Order Canceled", "Cancled");
            parent.showMenu();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected override event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
