/* Hunter Ruskanen
 * DrinkMenu.xaml.cs
 * menu for the drinks
*/

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
using BleakwindBuffet.Data.Drinks;


namespace PointOfSale.Combostuff
{
    /// <summary>
    /// Interaction logic for DrinkMenu.xaml
    /// </summary>
    public partial class DrinkMenu : UserControl
    {
        Combo curentCombo;

        public DrinkMenu(Combo combo)
        {
            this.curentCombo = combo;
            InitializeComponent();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addSailorSoda(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new SailorSoda(), 2);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addMarkarthMilk(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new MarkarthMilk(), 2);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new AretinoAppleJuice(), 2);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new CandlehearthCoffee(), 2);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addWarriorWater(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new WarriorWater(), 2);
        }
    }
}
