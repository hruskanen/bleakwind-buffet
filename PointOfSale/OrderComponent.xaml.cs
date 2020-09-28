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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public int currentListIndex = 0;
        
        /// <summary>
        /// creates the base and brings up the menu
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            showMenu();
        }

        /// <summary>
        /// brings up the menu
        /// </summary>
        public void showMenu()
        {
            containerBorder.Child = new MenuSelectionComponent(this);
        }

        /// <summary>
        /// switches to the correct edit screen based off the index
        /// </summary>
        public void swapScreens()
        {
            if (order.Items[currentListIndex].GetType() == typeof(BriarheartBurger))
            {
                containerBorder.Child = new BriarheartBurgerCustomization(this, (BriarheartBurger)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(DoubleDraugr))
            {
                containerBorder.Child = new DoubleDraugrCustomization(this, (DoubleDraugr)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(ThalmorTriple))
            {
                containerBorder.Child = new ThalmorTripleCustomization(this, (ThalmorTriple)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(SmokehouseSkeleton))
            {
                containerBorder.Child = new SmokehouseSkeletonCustomization(this, (SmokehouseSkeleton)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(GardenOrcOmelette))
            {
                containerBorder.Child = new GardenOrcOmeletteCustomization(this, (GardenOrcOmelette)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(PhillyPoacher))
            {
                containerBorder.Child = new PhillyPoacherCustomization(this, (PhillyPoacher)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(ThugsTBone))
            {
                containerBorder.Child = new ThugsTBoneCustomization(this, (ThugsTBone)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(SailorSoda))
            {
                containerBorder.Child = new SailorSodaCustomization(this, (SailorSoda)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(MarkarthMilk))
            {
                containerBorder.Child = new MarkarthMilkCustomization(this, (MarkarthMilk)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(AretinoAppleJuice))
            {
                containerBorder.Child = new AretinoAppleJuiceCustomization(this, (AretinoAppleJuice)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(CandlehearthCoffee))
            {
                containerBorder.Child = new CandlehearthCoffeeCustomization(this, (CandlehearthCoffee)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(WarriorWater))
            {
                containerBorder.Child = new WarriorWaterCustomization(this, (WarriorWater)order.Items[currentListIndex]);
            }

            else if (order.Items[currentListIndex].GetType() == typeof(VokunSalad))
            {
                containerBorder.Child = new VokunSaladCustomization(this, (VokunSalad)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(FriedMiraak))
            {
                containerBorder.Child = new FriedMiraakCustomization(this, (FriedMiraak)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(MadOtarGrits))
            {
                containerBorder.Child = new MadOtarGritsCustomization(this, (MadOtarGrits)order.Items[currentListIndex]);
            }
            else if (order.Items[currentListIndex].GetType() == typeof(DragonbornWaffleFries))
            {
                containerBorder.Child = new DragonbornWaffleFriesCustomization(this, (DragonbornWaffleFries)order.Items[currentListIndex]);
            }
        }

        /// <summary>
        /// makes the selected item on the list the current index and calls swapScreens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeItem(object sender, MouseButtonEventArgs e)
        {
            currentListIndex = order.Items.IndexOf(item: order.SelectedItem);
            swapScreens();
        }
    }
}
