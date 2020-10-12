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
using BleakwindBuffet.Data.Sides;


namespace PointOfSale.Combostuff
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
    {
        Combo curentCombo;

        public SideMenu(Combo combo)
        {
            this.curentCombo = combo;
            InitializeComponent();
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addVokunSalad(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new VokunSalad(), 3);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addFriedMiraak(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new FriedMiraak(), 3);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addMadOtarGrits(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new MadOtarGrits(), 3);
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            curentCombo.addItem(new DragonbornWaffleFries(), 3);
        }
    }
}
