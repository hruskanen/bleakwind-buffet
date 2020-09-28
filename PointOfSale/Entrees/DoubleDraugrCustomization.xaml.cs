/* Hunter Ruskanen
 * DoubleDraugrCustomization.xaml.cs
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
    /// Interaction logic for DoubleDraugrCustomization.xaml
    /// </summary>
    public partial class DoubleDraugrCustomization : UserControl
    {
        OrderComponent parent;

        /// <summary>
        /// imports the item and allows to to edit it or delete it
        /// </summary>
        /// <param name="orderComponent"> creates the parent</param>
        /// <param name="item">add the inputed item in to the Customization</param>
        public DoubleDraugrCustomization(OrderComponent orderComponent, DoubleDraugr item)
        {
            this.parent = orderComponent;
            InitializeComponent();
            _bun.IsChecked = item.Bun;
            _ketchup.IsChecked = item.Ketchup;
            _mustard.IsChecked = item.Mustard;
            _pickle.IsChecked = item.Pickle;
            _cheese.IsChecked = item.Cheese;
            _tomato.IsChecked = item.Tomato;
            _lettuce.IsChecked = item.Lettuce;
            _mayo.IsChecked = item.Mayo;
        }

        /// <summary>
        /// sends the item back to the OrderComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void customizationDone(object sender, RoutedEventArgs e)
        {
            DoubleDraugr item = new DoubleDraugr()
            {
                Bun = (bool)_bun.IsChecked,
                Ketchup = (bool)_ketchup.IsChecked,
                Mustard = (bool)_mustard.IsChecked,
                Pickle = (bool)_pickle.IsChecked,
                Cheese = (bool)_cheese.IsChecked,
                Tomato = (bool)_tomato.IsChecked,
                Lettuce = (bool)_lettuce.IsChecked,
                Mayo = (bool)_mayo.IsChecked
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
