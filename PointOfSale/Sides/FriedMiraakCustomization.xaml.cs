/* Hunter Ruskanen
 * FriedMiraakCustomization.xaml.cs
 * imports the item and allows to to edit it or delete it
*/
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for FriedMiraakCustomization.xaml
    /// </summary>
    public partial class FriedMiraakCustomization : UserControl
    {
        OrderComponent parent;

        /// <summary>
        /// imports the item and allows to to edit it or delete it
        /// </summary>
        /// <param name="orderComponent"> creates the parent</param>
        /// <param name="item">add the inputed item in to the Customization</param>
        public FriedMiraakCustomization(OrderComponent orderComponent, FriedMiraak item)
        {
            this.parent = orderComponent;
            InitializeComponent();
            if (item.Size == BleakwindBuffet.Data.Enums.Size.Small) _size.SelectedItem = _small;
            if (item.Size == BleakwindBuffet.Data.Enums.Size.Medium) _size.SelectedItem = _meduim;
            if (item.Size == BleakwindBuffet.Data.Enums.Size.Large) _size.SelectedItem = _large;
        }

        /// <summary>
        /// sends the item back to the OrderComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void customizationDone(object sender, RoutedEventArgs e)
        {
            FriedMiraak item = new FriedMiraak();
            if (_size.SelectedItem == _small) item.Size = BleakwindBuffet.Data.Enums.Size.Small;
            if (_size.SelectedItem == _meduim) item.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            if (_size.SelectedItem == _large) item.Size = BleakwindBuffet.Data.Enums.Size.Large;
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
