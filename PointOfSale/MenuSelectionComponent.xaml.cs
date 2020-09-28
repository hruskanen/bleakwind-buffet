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
        OrderComponent parent;

        /// <summary>
        /// creates the menu and assigns the parent class
        /// </summary>
        /// <param name="orderComponent"></param>
        public MenuSelectionComponent(OrderComponent orderComponent)
        {
            this.parent = orderComponent;
            InitializeComponent();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addBriarheartBurger(object sender, RoutedEventArgs e)
        {
            BriarheartBurger item = new BriarheartBurger();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addDoubleDraugr(object sender, RoutedEventArgs e)
        {
            DoubleDraugr item = new DoubleDraugr();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addThalmorTriple(object sender, RoutedEventArgs e)
        {
            ThalmorTriple item = new ThalmorTriple();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette item = new GardenOrcOmelette();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addPhillyPoacher(object sender, RoutedEventArgs e)
        {
            PhillyPoacher item = new PhillyPoacher();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addThugsTBone(object sender, RoutedEventArgs e)
        {
            ThugsTBone item = new ThugsTBone();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addSailorSoda(object sender, RoutedEventArgs e)
        {
            SailorSoda item = new SailorSoda();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addMarkarthMilk(object sender, RoutedEventArgs e)
        {
            MarkarthMilk item = new MarkarthMilk();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice item = new AretinoAppleJuice();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee item = new CandlehearthCoffee();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addWarriorWater(object sender, RoutedEventArgs e)
        {
            WarriorWater item = new WarriorWater();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addVokunSalad(object sender, RoutedEventArgs e)
        {
            VokunSalad item = new VokunSalad();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addFriedMiraak(object sender, RoutedEventArgs e)
        {
            FriedMiraak item = new FriedMiraak();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addMadOtarGrits(object sender, RoutedEventArgs e)
        {
            MadOtarGrits item = new MadOtarGrits();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries item = new DragonbornWaffleFries();
            parent.currentListIndex = parent.order.Items.Count;
            parent.order.Items.Add(item);
            parent.swapScreens();
        }
    }
}
