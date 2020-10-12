/* Hunter Ruskanen
 * MenuSelectionComponent.xaml.cs
 * The menu
*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        Order curentOrder;

        /// <summary>
        /// creates the menu and assigns the parent class
        /// </summary>
        /// <param name="orderComponent"></param>
        public MenuSelectionComponent(Order order)
        {
            this.curentOrder = order;
            InitializeComponent();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addBriarheartBurger(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new BriarheartBurger());            
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addDoubleDraugr(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new DoubleDraugr());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addThalmorTriple(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new ThalmorTriple());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new SmokehouseSkeleton());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new GardenOrcOmelette());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addPhillyPoacher(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new PhillyPoacher());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addThugsTBone(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new ThugsTBone());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addSailorSoda(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new SailorSoda());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addMarkarthMilk(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new MarkarthMilk());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new AretinoAppleJuice());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new CandlehearthCoffee());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addWarriorWater(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new WarriorWater());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addVokunSalad(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new VokunSalad());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addFriedMiraak(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new FriedMiraak());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addMadOtarGrits(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new MadOtarGrits());
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            curentOrder.Add(new DragonbornWaffleFries());
        }
    }
}
