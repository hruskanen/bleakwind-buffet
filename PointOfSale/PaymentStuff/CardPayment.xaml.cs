/* Hunter Ruskanen
 * CardPayment.xaml.cs
 * handles payment via card
*/

using RoundRegister;
using System;
using System.Collections.Generic;
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

namespace PointOfSale.PaymentStuff
{
    /// <summary>
    /// Interaction logic for CardPayment.xaml
    /// </summary>
    public partial class CardPayment : UserControl
    {
        /// <summary>
        /// the current payment screen
        /// </summary>
        Payment paymentScreen;

        /// <summary>
        /// the constructor for the cardpayment
        /// </summary>
        /// <param name="payment"></param>
        public CardPayment(Payment payment)
        {
            paymentScreen = payment;
            DataContext = paymentScreen.currentOrder;
            InitializeComponent();
        }

        /// <summary>
        /// simulates what might heppen when a card is swiped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void scanCard(object sender, RoutedEventArgs e)
        {
            switch (CardReader.RunCard(paymentScreen.currentOrder._total))
            {
                case CardTransactionResult.Approved:
                    MessageBox.Show("Card Approved", "Card Approved");
                    paymentScreen.endPayment("Card");
                    break;
                case CardTransactionResult.Declined:
                    MessageBox.Show("Card Declined", "Card Declined");
                    break;
                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Incorrect Pin", "Incorrect Pin");
                    break;
                case CardTransactionResult.InsufficientFunds:
                    MessageBox.Show("Insufficient Funds", "Insufficient Funds");
                    break;
                case CardTransactionResult.ReadError:
                    MessageBox.Show("Read Error", "Read Error");
                    break;
            }
        }
    }
}
