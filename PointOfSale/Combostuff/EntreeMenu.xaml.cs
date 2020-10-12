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
using BleakwindBuffet.Data.Entrees;
using PointOfSale.Entrees;

namespace PointOfSale.Combostuff
{
    /// <summary>
    /// Interaction logic for EntreeMenu.xaml
    /// </summary>
    public partial class EntreeMenu : UserControl
    {
        Combo curentCombo;

        /// <summary>
        /// creates the menu and assigns the parent class
        /// </summary>
        /// <param name="orderComponent"></param>
        public EntreeMenu(Combo combo)
        {
            this.curentCombo = combo;
            InitializeComponent();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addBriarheartBurger(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new BriarheartBurger(), 1);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addDoubleDraugr(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new DoubleDraugr(), 1);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addThalmorTriple(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new ThalmorTriple(), 1);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new SmokehouseSkeleton(), 1);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new GardenOrcOmelette(), 1);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addPhillyPoacher(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new PhillyPoacher(), 1);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addThugsTBone(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new ThugsTBone(), 1);
        }
    }
}
