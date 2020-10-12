/* Hunter Ruskanen
 * OrderComponent.xaml.cs
 * The base of the menu
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

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Drinks;
using PointOfSale.Sides;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        
        public Order curentOrder { get; set; }

        /// <summary>
        /// creates the base and brings up the menu
        /// </summary>
        public OrderComponent()
        {
            curentOrder = new Order(this);
            InitializeComponent();
            showMenu();
        }

        /// <summary>
        /// brings up the menu
        /// </summary>
        public void showMenu()
        {
            DataContext = this;
            order.Items.Refresh();
            containerBorder.Child = new MenuSelectionComponent(curentOrder);
        }

        /// <summary>
        /// switches to the correct edit screen based off the index
        /// </summary>
        public void swapScreens()
        {
            if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(BriarheartBurger))
            {
                containerBorder.Child = new BriarheartBurgerCustomization(curentOrder, (BriarheartBurger)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(DoubleDraugr))
            {
                containerBorder.Child = new DoubleDraugrCustomization(curentOrder, (DoubleDraugr)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(ThalmorTriple))
            {
                containerBorder.Child = new ThalmorTripleCustomization(curentOrder, (ThalmorTriple)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(SmokehouseSkeleton))
            {
                containerBorder.Child = new SmokehouseSkeletonCustomization(curentOrder, (SmokehouseSkeleton)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(GardenOrcOmelette))
            {
                containerBorder.Child = new GardenOrcOmeletteCustomization(curentOrder, (GardenOrcOmelette)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(PhillyPoacher))
            {
                containerBorder.Child = new PhillyPoacherCustomization(curentOrder, (PhillyPoacher)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(ThugsTBone))
            {
                containerBorder.Child = new ThugsTBoneCustomization(curentOrder, (ThugsTBone)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(SailorSoda))
            {
                containerBorder.Child = new SailorSodaCustomization(curentOrder, (SailorSoda)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(MarkarthMilk))
            {
                containerBorder.Child = new MarkarthMilkCustomization(curentOrder, (MarkarthMilk)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(AretinoAppleJuice))
            {
                containerBorder.Child = new AretinoAppleJuiceCustomization(curentOrder, (AretinoAppleJuice)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(CandlehearthCoffee))
            {
                containerBorder.Child = new CandlehearthCoffeeCustomization(curentOrder, (CandlehearthCoffee)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(WarriorWater))
            {
                containerBorder.Child = new WarriorWaterCustomization(curentOrder, (WarriorWater)curentOrder.orders[curentOrder.currentListIndex]);
            }

            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(VokunSalad))
            {
                containerBorder.Child = new VokunSaladCustomization(curentOrder, (VokunSalad)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(FriedMiraak))
            {
                containerBorder.Child = new FriedMiraakCustomization(curentOrder, (FriedMiraak)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(MadOtarGrits))
            {
                containerBorder.Child = new MadOtarGritsCustomization(curentOrder, (MadOtarGrits)curentOrder.orders[curentOrder.currentListIndex]);
            }
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(DragonbornWaffleFries))
            {
                containerBorder.Child = new DragonbornWaffleFriesCustomization(curentOrder, (DragonbornWaffleFries)curentOrder.orders[curentOrder.currentListIndex]);
            }
            //Combos
            else if (curentOrder.orders[curentOrder.currentListIndex].GetType() == typeof(List<IOrderItem>))
            {
                
                containerBorder.Child = new Combo(curentOrder, (List<IOrderItem>)curentOrder.orders[curentOrder.currentListIndex]);
            }

        }

        /// <summary>
        /// makes the selected item on the list the current index and calls swapScreens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeItem(object sender, MouseButtonEventArgs e)
        {
            curentOrder.currentListIndex = curentOrder.orders.IndexOf(item: (object)order.SelectedItem);
            swapScreens();
        }

        /// <summary>
        /// Cancles the current order and clears the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cancelOrder(object sender, RoutedEventArgs e)
        {
            curentOrder.cancelOrder();
        }

        /// <summary>
        /// Sends the current order and clears the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void sendOrder(object sender, RoutedEventArgs e)
        {
            curentOrder.sendOrder();
        }

        /// <summary>
        /// creates combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void createCombo(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new Combo(curentOrder, new List<IOrderItem>() { null, null, null });
        }
    }
}
