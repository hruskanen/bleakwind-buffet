/* Hunter Ruskanen
 * AretinoAppleJuice.xaml.cs
 * imports the item and allows to to edit it or delete it
*/
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for SailorSodaCustomization.xaml
    /// </summary>
    public partial class SailorSodaCustomization : UserControl
    {
        OrderComponent parent;

        /// <summary>
        /// imports the item and allows to to edit it or delete it
        /// </summary>
        /// <param name="orderComponent"> creates the parent</param>
        /// <param name="item">add the inputed item in to the Customization</param>
        public SailorSodaCustomization(OrderComponent orderComponent, SailorSoda item)
        {
            this.parent = orderComponent;
            InitializeComponent();
            if (item.Size == BleakwindBuffet.Data.Enums.Size.Small) _size.SelectedItem = _small;
            if (item.Size == BleakwindBuffet.Data.Enums.Size.Medium) _size.SelectedItem = _meduim;
            if (item.Size == BleakwindBuffet.Data.Enums.Size.Large) _size.SelectedItem = _large;
            if (item.Flavor == SodaFlavor.Blackberry) _flavor.SelectedItem = _blackberry;
            if (item.Flavor == SodaFlavor.Cherry) _flavor.SelectedItem = _cherry;
            if (item.Flavor == SodaFlavor.Grapefruit) _flavor.SelectedItem = _grapefruit;
            if (item.Flavor == SodaFlavor.Lemon) _flavor.SelectedItem = _lemon;
            if (item.Flavor == SodaFlavor.Peach) _flavor.SelectedItem = _peach;
            if (item.Flavor == SodaFlavor.Watermelon) _flavor.SelectedItem = _watermelon;
            _ice.IsChecked = item.Ice;
        }

        /// <summary>
        /// sends the item back to the OrderComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void customizationDone(object sender, RoutedEventArgs e)
        {
            SailorSoda item = new SailorSoda()
            {
                Ice = (bool)_ice.IsChecked
            };
            if (_size.SelectedItem == _small) item.Size = BleakwindBuffet.Data.Enums.Size.Small;
            if (_size.SelectedItem == _meduim) item.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            if (_size.SelectedItem == _large) item.Size = BleakwindBuffet.Data.Enums.Size.Large;
            if (_flavor.SelectedItem == _blackberry) item.Flavor = SodaFlavor.Blackberry;
            if (_flavor.SelectedItem == _cherry) item.Flavor = SodaFlavor.Cherry;
            if (_flavor.SelectedItem == _grapefruit) item.Flavor = SodaFlavor.Grapefruit;
            if (_flavor.SelectedItem == _lemon) item.Flavor = SodaFlavor.Lemon;
            if (_flavor.SelectedItem == _peach) item.Flavor = SodaFlavor.Peach;
            if (_flavor.SelectedItem == _watermelon) item.Flavor = SodaFlavor.Watermelon;
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
