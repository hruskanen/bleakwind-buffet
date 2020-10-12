/* Hunter Ruskanen
 * ThugsTBoneCustomization.xaml.cs
 * imports the item and allows to to edit it or delete it
*/
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for ThugsTBoneCustomization.xaml
    /// </summary>
    public partial class ThugsTBoneCustomization : UserControl, INotifyPropertyChanged
    {
        Order curentOrder = null;
        Combo curentCombo = null;
        double orgPrice;
        uint orgCalories;
        private ThugsTBone _Item;
        public ThugsTBone Item
        {
            get { return _Item; }
            set
            {
                if (_Item != value)
                {
                    _Item = value;
                    NotifyPropertyChanged("Item");
                }
            }
        }

        /// <summary>
        /// imports the item and allows to to edit it or delete it
        /// </summary>
        /// <param name="orderComponent"> creates the parent</param>
        /// <param name="item">add the inputed item in to the Customization</param>
        public ThugsTBoneCustomization(Order order, ThugsTBone item)
        {
            Item = item;
            orgPrice = item.Price;
            orgCalories = item.Calories;
            this.curentOrder = order;
            DataContext = this;
            InitializeComponent();
        }
        /// <summary>
        /// imports the item and allows to to edit it or delete it
        /// </summary>
        /// <param name="combo"> creates the combo parent</param>
        /// <param name="item">add the inputed item in to the Customization</param>
        public ThugsTBoneCustomization(Combo combo, ThugsTBone item)
        {
            Item = item;
            orgPrice = item.Price;
            orgCalories = item.Calories;
            this.curentCombo = combo;
            DataContext = this;
            InitializeComponent();
        }

        /// <summary>
        /// sends the item back to the OrderComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void customizationDone(object sender, RoutedEventArgs e)
        {
            if (curentOrder != null)
            {
                curentOrder.Change(Item, orgPrice, orgCalories);
            }
            else
            {
                curentCombo.updateItem(Item, 1, orgPrice, orgCalories);
            }
        }

        /// <summary>
        /// Deletes the item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void customizationRemove(object sender, RoutedEventArgs e)
        {
            if (curentOrder != null)
            {
                curentOrder.Remove(orgPrice, orgCalories);
            }
            else
            {
                curentCombo.removeItem(1, orgPrice, orgCalories);
            }
        }

        /// <summary>
        /// Creats and event handler if a property has changed
        /// </summary>
        /// <param name="propertyName"> the property that changed </param>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
