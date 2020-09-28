/* Hunter Ruskanen
 * PhillyPoacherCustomization.xaml.cs
 * imports the item and allows to to edit it or delete it
*/
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for PhillyPoacherCustomization.xaml
    /// </summary>
    public partial class PhillyPoacherCustomization : UserControl
    {
        OrderComponent parent;

        /// <summary>
        /// imports the item and allows to to edit it or delete it
        /// </summary>
        /// <param name="orderComponent"> creates the parent</param>
        /// <param name="item">add the inputed item in to the Customization</param>
        public PhillyPoacherCustomization(OrderComponent orderComponent, PhillyPoacher item)
        {
            this.parent = orderComponent;
            InitializeComponent();
            _serloin.IsChecked = item.Sirloin;
            _onion.IsChecked = item.Onion;
            _roll.IsChecked = item.Roll;
        }

        /// <summary>
        /// sends the item back to the OrderComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void customizationDone(object sender, RoutedEventArgs e)
        {
            PhillyPoacher item = new PhillyPoacher()
            {
                Sirloin = (bool)_serloin.IsChecked,
                Onion = (bool)_onion.IsChecked,
                Roll = (bool)_roll.IsChecked
            };
            parent.order.Items[parent.currentListIndex] = item;
            parent.showMenu();
        }

        /// <summary>
        /// Deletes the item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void customizationRemove(object sender, RoutedEventArgs e)
        {
            parent.order.Items.RemoveAt(parent.currentListIndex);
            parent.showMenu();
        }
    }
}
