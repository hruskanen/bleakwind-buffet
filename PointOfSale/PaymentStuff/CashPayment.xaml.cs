/* Hunter Ruskanen
 * CashPayment.xaml.cs
 * handles payment via cash
*/

using RoundRegister;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// the current payment screen
        /// </summary>
        public Payment paymentScreen;

        /// <summary>
        /// amount of hundreds
        /// </summary>
        private int Hundreds;
        public int hundreds
        {
            get { return Hundreds; }
            set
            {
                if (Hundreds != value)
                {
                    Hundreds = value;
                    NotifyPropertyChanged("hundreds");
                }
            }
        }

        /// <summary>
        /// amount of Fifties
        /// </summary>
        private int Fifties;
        public int fifties
        {
            get { return Fifties; }
            set
            {
                if (Fifties != value)
                {
                    Fifties = value;
                    NotifyPropertyChanged("fifties");
                }
            }
        }

        /// <summary>
        /// amount of Twenties
        /// </summary>
        private int Twenties;
        public int twenties
        {
            get { return Twenties; }
            set
            {
                if (Twenties != value)
                {
                    Twenties = value;
                    NotifyPropertyChanged("twenties");
                }
            }
        }

        /// <summary>
        /// amount of tens
        /// </summary>
        private int Tens;
        public int tens
        {
            get { return Tens; }
            set
            {
                if (Tens != value)
                {
                    Tens = value;
                    NotifyPropertyChanged("tens");
                }
            }
        }

        /// <summary>
        /// amount of fives
        /// </summary>
        private int Fives;
        public int fives
        {
            get { return Fives; }
            set
            {
                if (Fives != value)
                {
                    Fives = value;
                    NotifyPropertyChanged("fives");
                }
            }
        }

        /// <summary>
        /// amount of twos
        /// </summary>
        private int Twos;
        public int twos
        {
            get { return Twos; }
            set
            {
                if (Twos != value)
                {
                    Twos = value;
                    NotifyPropertyChanged("twos");
                }
            }
        }

        /// <summary>
        /// amount of ones
        /// </summary>
        private int Ones;
        public int ones
        {
            get { return Ones; }
            set
            {
                if (Ones != value)
                {
                    Ones = value;
                    NotifyPropertyChanged("ones");
                }
            }
        }

        /// <summary>
        /// amount of dollars
        /// </summary>
        private int Dollars;
        public int dollars
        {
            get { return Dollars; }
            set
            {
                if (Dollars != value)
                {
                    Dollars = value;
                    NotifyPropertyChanged("dollars");
                }
            }
        }

        /// <summary>
        /// amount of HalfDollars
        /// </summary>
        private int HalfDollars;
        public int halfDollars
        {
            get { return HalfDollars; }
            set
            {
                if (HalfDollars != value)
                {
                    HalfDollars = value;
                    NotifyPropertyChanged("halfDollars");
                }
            }
        }

        /// <summary>
        /// amount of Quarters
        /// </summary>
        private int Quarters;
        public int quarters
        {
            get { return Quarters; }
            set
            {
                if (Quarters != value)
                {
                    Quarters = value;
                    NotifyPropertyChanged("quarters");
                }
            }
        }

        /// <summary>
        /// amount of Dimes
        /// </summary>
        private int Dimes;
        public int dimes
        {
            get { return Dimes; }
            set
            {
                if (Dimes != value)
                {
                    Fives = value;
                    NotifyPropertyChanged("dimes");
                }
            }
        }

        /// <summary>
        /// amount of Nickels
        /// </summary>
        private int Nickels;
        public int nickels
        {
            get { return Nickels; }
            set
            {
                if (Nickels != value)
                {
                    Nickels = value;
                    NotifyPropertyChanged("nickels");
                }
            }
        }

        /// <summary>
        /// amount of Pennies
        /// </summary>
        private int Pennies;
        public int pennies
        {
            get { return Pennies; }
            set
            {
                if (Pennies != value)
                {
                    Pennies = value;
                    NotifyPropertyChanged("pennies");
                }
            }
        }

        double total = 0;

        /// <summary>
        /// the constructor for the cashpayment
        /// </summary>
        /// <param name="payment"></param>
        public CashPayment(Payment payment)
        {
            this.paymentScreen = payment;
            DataContext = this;
            InitializeComponent();
            buttonTest();
        }

        /// <summary>
        /// tests to see if any buttons need to be disabled
        /// </summary>
        void buttonTest()
        {
            hundredDown.IsEnabled = hundreds > 0 && CashDrawer.Hundreds > 0;
            fiftyDown.IsEnabled = fifties > 0 && CashDrawer.Fifties > 0;
            twentyDown.IsEnabled = twenties > 0 && CashDrawer.Twenties > 0;
            tenDown.IsEnabled = tens > 0 && CashDrawer.Tens > 0;
            fiveDown.IsEnabled = fives > 0 && CashDrawer.Fives > 0;
            twoDown.IsEnabled = twos > 0 && CashDrawer.Twos > 0;
            oneDown.IsEnabled = ones > 0 && CashDrawer.Ones > 0;
            dollarDown.IsEnabled = dollars > 0 && CashDrawer.Dollars > 0;
            halfDollarDown.IsEnabled = halfDollars > 0 && CashDrawer.HalfDollars > 0;
            quarterDown.IsEnabled = quarters > 0 && CashDrawer.Quarters > 0;
            dimeDown.IsEnabled = dimes > 0 && CashDrawer.Dimes > 0;
            nickelDown.IsEnabled = nickels > 0 && CashDrawer.Nickels > 0;
            pennyDown.IsEnabled = pennies > 0 && CashDrawer.Pennies > 0;

            CashPay.IsEnabled = total >= paymentScreen.currentOrder._total;
        }


        /// <summary>
        /// Handles the click of a "number" button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguements</param>
        void onNumberPress(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            
            if (button.Tag.Equals("100") && button.Content.Equals("+"))
            {
                hundreds++;
                CashDrawer.Hundreds++;
                total += 100;
            }
            else if (button.Tag.Equals("100") && button.Content.Equals("-"))
            {
                hundreds--;
                CashDrawer.Hundreds--;
                total -= 100;
            }
            else if (button.Tag.Equals("50") && button.Content.Equals("+"))
            {
                fifties++;
                CashDrawer.Fifties++;
                total += 50;
            }
            else if (button.Tag.Equals("50") && button.Content.Equals("-"))
            {
                fifties--;
                CashDrawer.Fifties--;
                total -= 50;
            }
            else if (button.Tag.Equals("20") && button.Content.Equals("+"))
            {
                twenties++;
                CashDrawer.Twenties++;
                total += 20;
            }
            else if (button.Tag.Equals("20") && button.Content.Equals("-"))
            {
                twenties--;
                CashDrawer.Twenties--;
                total -= 20;
            }
            else if (button.Tag.Equals("10") && button.Content.Equals("+"))
            {
                tens++;
                CashDrawer.Tens++;
                total += 10;
            }
            else if (button.Tag.Equals("10") && button.Content.Equals("-"))
            {
                tens--;
                CashDrawer.Tens--;
                total -= 10;
            }
            else if (button.Tag.Equals("5") && button.Content.Equals("+"))
            {
                fives++;
                CashDrawer.Fives++;
                total += 5;
            }
            else if (button.Tag.Equals("5") && button.Content.Equals("-"))
            {
                fives--;
                CashDrawer.Fives--;
                total -= 5;
            }
            else if (button.Tag.Equals("2") && button.Content.Equals("+"))
            {
                twos++;
                CashDrawer.Twos++;
                total += 2;
            }
            else if (button.Tag.Equals("2") && button.Content.Equals("-"))
            {
                twos--;
                CashDrawer.Twos--;
                total -= 2;
            }
            else if (button.Tag.Equals("1") && button.Content.Equals("+"))
            {
                ones++;
                CashDrawer.Ones++;
                total += 1;
            }
            else if (button.Tag.Equals("1") && button.Content.Equals("-"))
            {
                ones--;
                CashDrawer.Ones--;
                total -= 1;
            }
            else if (button.Tag.Equals("101") && button.Content.Equals("+"))
            {
                dollars++;
                CashDrawer.Dollars++;
                total += 1;
            }
            else if (button.Tag.Equals("101") && button.Content.Equals("-"))
            {
                dollars--;
                CashDrawer.Dollars--;
                total -= 1;
            }
            else if (button.Tag.Equals(".50") && button.Content.Equals("+"))
            {
                halfDollars++;
                CashDrawer.HalfDollars++;
                total += .50;
            }
            else if (button.Tag.Equals(".50") && button.Content.Equals("-"))
            {
                halfDollars--;
                CashDrawer.HalfDollars--;
                total -= .50;
            }
            else if (button.Tag.Equals(".25") && button.Content.Equals("+"))
            {
                quarters++;
                CashDrawer.Quarters++;
                total += .25;
            }
            else if (button.Tag.Equals(".25") && button.Content.Equals("-"))
            {
                quarters--;
                CashDrawer.Quarters--;
                total -= .25;
            }
            else if (button.Tag.Equals(".10") && button.Content.Equals("+"))
            {
                dimes++;
                CashDrawer.Dimes++;
                total += .10;
            }
            else if (button.Tag.Equals(".10") && button.Content.Equals("-"))
            {
                dimes--;
                CashDrawer.Dimes--;
                total -= .10;
            }
            else if (button.Tag.Equals(".05") && button.Content.Equals("+"))
            {
                nickels++;
                CashDrawer.Nickels++;
                total += .05;
            }
            else if (button.Tag.Equals(".05") && button.Content.Equals("-"))
            {
                nickels--;
                CashDrawer.Nickels--;
                total -= .05;
            }
            else if (button.Tag.Equals(".01") && button.Content.Equals("+"))
            {
                pennies++;
                CashDrawer.Pennies++;
                total += .01;
            }
            else if (button.Tag.Equals(".01") && button.Content.Equals("-"))
            {
                Pennies--;
                CashDrawer.Pennies--;
                total -= .01;
            }
            buttonTest();
        }

        /// <summary>
        /// ends the cash payment and caculates how much change should be given
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void endCash(object sender, RoutedEventArgs e)
        {
            total = Math.Round(total - paymentScreen.currentOrder._total, 2, MidpointRounding.AwayFromZero);
            paymentScreen.changeDue = total;
            string change = "Change: $" + total.ToString() + "\n";

            if (((int)(total / 100)) != 0) change += ((int)(total / 100)).ToString() + " Hundred(s)\n";
            total %= 100;
            if (((int)(total / 50)) != 0) change += ((int)(total / 50)).ToString() + " Fifty(s)\n";
            total %= 50;
            if (((int)(total / 20)) != 0) change += ((int)(total / 20)).ToString() + " Twenty(s)\n";
            total %= 20;
            if (((int)(total / 10)) != 0) change += ((int)(total / 10)).ToString() + " Ten(s)\n";
            total %= 10;
            if (((int)(total / 1)) != 0) change += ((int)(total / 1)).ToString() + " One(s)\n";
            total %= 1;
            if (((int)(total / .50)) != 0) change += ((int)(total / .50)).ToString() + " Half Dollars(s)\n";
            total = Math.Round(total % .50, 2, MidpointRounding.AwayFromZero);
            if (((int)(total / .25)) != 0) change += ((int)(total / .25)).ToString() + " Quarter(s)\n";
            total = Math.Round(total % .25, 2, MidpointRounding.AwayFromZero);
            if (((int)(total / .10)) != 0) change += ((int)(total / .10)).ToString() + " Dimes(s)\n";
            total = Math.Round(total % .10, 2, MidpointRounding.AwayFromZero);
            if (((int)(total / .05)) != 0) change += ((int)(total / .05)).ToString() + " Nickel(s)\n";
            total = Math.Round(total % .05, 2, MidpointRounding.AwayFromZero);
            if (((int)(total / .01)) != 0) change += ((int)(total / .01)).ToString() + " Penny(s)";

            MessageBox.Show(change);
            paymentScreen.endPayment("Cash");
        }
        
        /// <summary>
        /// propery change
        /// </summary>
        /// <param name="propertyName"></param>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
