/* Hunter Ruskanen
 * Payment.xaml.cs
 * The base of the Payment
*/

using BleakwindBuffet.Data;
using PointOfSale.PaymentStuff;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// The current order
        /// </summary>
        public Order currentOrder;

        /// <summary>
        /// The current amount of change
        /// </summary>
        private double ChangeDue = 0;
        public double changeDue
        {
            get { return ChangeDue; }
            set
            {
                if(ChangeDue != value)
                {
                    ChangeDue = value;
                    NotifyPropertyChanged("changeDue");
                }
            }
        }

        /// <summary>
        /// the payment constructor
        /// </summary>
        /// <param name="order"> the current order </param>
        public Payment(Order order)
        {
            DataContext = this;
            this.currentOrder = order;
            InitializeComponent();
            amountDue.Content = "$" + currentOrder._total;
        }

        /// <summary>
        /// the button for choosing cash as your payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cashButton(object sender, RoutedEventArgs e)
        {
            PaymentOptions.Child = new CashPayment(this);
        }

        /// <summary>
        /// the button for choosing cash as your payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cardButton(object sender, RoutedEventArgs e)
        {
            PaymentOptions.Child = new CardPayment(this);
        }

        /// <summary>
        /// button used to return to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void returnToOrder(object sender, RoutedEventArgs e)
        {
            PaymentOptions.Child = null;
            currentOrder.parent.showMenu();
            currentOrder.parent.overrideBorder.Child = null;
        }

        /// <summary>
        /// the method used to end the current payment and print the receipt
        /// </summary>
        /// <param name="x"> the type of paymenty used </param>
        public void endPayment(string x)
        {
            amountDue.Content = "$0.00";
            PaymentOptions.Child = null;
            RecieptPrinter.PrintLine(currentOrder._orderNumber.ToString());
            RecieptPrinter.PrintLine("10/15/2020 12:36");
            foreach (object temp in currentOrder.orders)
            {
                if(temp is Combo item)
                {
                    RecieptPrinter.PrintLine(item.ToString());
                    RecieptPrinter.PrintLine(item.Price.ToString());
                    foreach(string thing in item.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("- " + thing);
                    }
                }
                else 
                {
                    IOrderItem orderItem = (IOrderItem)temp;
                    RecieptPrinter.PrintLine(orderItem.ToString());
                    RecieptPrinter.PrintLine(orderItem.Price.ToString());
                    foreach (string thing in orderItem.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("- " + thing);
                    }
                }
            }
            RecieptPrinter.PrintLine(currentOrder._subTotal.ToString());
            RecieptPrinter.PrintLine(Math.Round(currentOrder._tax, 2, MidpointRounding.AwayFromZero).ToString());
            RecieptPrinter.PrintLine(currentOrder._total.ToString());
            RecieptPrinter.PrintLine(x);
            RecieptPrinter.PrintLine(changeDue.ToString());
            RecieptPrinter.CutTape();

            currentOrder.parent.overrideBorder.Child = null;
            currentOrder.resetOrder();
        }

        /// <summary>
        ///  porpert changed
        /// </summary>
        /// <param name="propertyName"></param>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
