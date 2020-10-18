/* Hunter Ruskanen
 * Combo.xaml.cs
 * Handles the cobos for the menu
*/

using BleakwindBuffet.Data;
using PointOfSale.Combostuff;
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
using PointOfSale.Entrees;
using PointOfSale.Drinks;
using PointOfSale.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Combo.xaml
    /// </summary>
    public partial class Combo : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// access back to the current order class
        /// </summary>
        Order curentOrder;

        /// <summary>
        /// the entree for the combo
        /// </summary>
        private IOrderItem ComboEntree = null;
        public IOrderItem comboEntree
        {
            get { return ComboEntree; }
            set
            {
                if (ComboEntree != value)
                {
                    ComboEntree = value;
                    NotifyPropertyChanged("comboEntree");
                    if (ComboEntree == null)
                    {
                        entreeName = " ";
                    }
                    else
                    {
                        entreeName = ComboEntree.ToString();
                    }
                }
            }
        }
        private string EntreeName;
        public string entreeName
        {
            get { return EntreeName; }
            set
            {
                if (EntreeName != value)
                {
                    EntreeName = value;
                    NotifyPropertyChanged("entreeName");
                }
            }
        }

        /// <summary>
        /// the drink for the combo
        /// </summary>
        private IOrderItem ComboDrink = null;
        public IOrderItem comboDrink
        {
            get { return ComboDrink; }
            set
            {
                if (ComboDrink != value)
                {
                    ComboDrink = value;
                    NotifyPropertyChanged("comboDrink");
                    if (ComboDrink == null)
                    {
                        drinkName = " ";
                    }
                    else
                    {
                        drinkName = ComboDrink.ToString();
                    }
                    
                }
            }
        }
        private string DrinkName;
        public string drinkName
        {
            get { return DrinkName; }
            set
            {
                if (DrinkName != value)
                {
                    DrinkName = value;
                    NotifyPropertyChanged("drinkName");
                }
            }
        }

        /// <summary>
        /// the side for the combo
        /// </summary>
        private IOrderItem ComboSide = null;
        public IOrderItem comboSide
        {
            get { return ComboSide; }
            set
            {
                if (ComboSide != value)
                {
                    ComboSide = value;
                    NotifyPropertyChanged("comboSide");
                    if (ComboSide == null)
                    {
                        sideName = " ";
                    }
                    else
                    {
                        sideName = ComboSide.ToString();
                    }
                }
            }
        }
        private string SideName;
        public string sideName
        {
            get { return SideName; }
            set
            {
                if (SideName != value)
                {
                    SideName = value;
                    NotifyPropertyChanged("sideName");
                }
            }
        }


        /// <summary>
        /// the curent price and calories for the combo
        /// </summary>
        private double price = 0;
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    NotifyPropertyChanged("Price");
                }
            }
        }
        private uint _ComboCalories = 0;
        public uint _comboCalories
        {
            get { return _ComboCalories; }
            set
            {
                if (_ComboCalories != value)
                {
                    _ComboCalories = value;
                    NotifyPropertyChanged("_comboCalories");
                }
            }
        }

        /// <summary>
        /// if the combo is new or not
        /// </summary>
        public bool newCombo = true;

        /// <summary>
        /// the original price and calories
        /// </summary>
        double orgPrice;
        uint orgCalories;

        /// <summary>
        /// the constructor
        /// </summary>
        /// <param name="order">the access back to the order class</param>
        /// <param name="combo"> the combo list</param>
        public Combo(Order order, IOrderItem entree, IOrderItem drink, IOrderItem side)
        {
            if (entree != null && drink != null && side != null)
            {
                orgPrice = entree.Price + drink.Price + side.Price;
                Price = entree.Price + drink.Price + side.Price;
                NotifyPropertyChanged("Price");
                orgCalories = entree.Calories + drink.Calories + side.Calories;
                _comboCalories = entree.Calories + drink.Calories + side.Calories;
                NotifyPropertyChanged("_comboCalories");
                newCombo = false;
            }
            comboEntree = entree;
            NotifyPropertyChanged("comboEntree");
            comboDrink = drink;
            NotifyPropertyChanged("comboDrink");
            comboSide = side;
            NotifyPropertyChanged("comboSide");

            this.curentOrder = order;
            InitializeComponent();
            showCombo();
        }

        /// <summary>
        /// shows the combo screen
        /// </summary>
        public void showCombo()
        {
            coco.IsEnabled = (comboEntree != null && comboDrink != null && comboSide != null);
            b1.IsEnabled = comboEntree != null;
            b2.IsEnabled = comboDrink != null;
            b3.IsEnabled = comboSide != null;

            DataContext = this;
            editBorder.Child = null;
            if (comboEntree == null) entreeBorder.Child = new EntreeMenu(this);
            if (comboDrink == null) drinkBorder.Child = new DrinkMenu(this);
            if (comboSide == null) sideBorder.Child = new SideMenu(this);
        }

        /// <summary>
        /// updating the current combo
        /// </summary>
        /// <param name="item"> the item beinmg tested</param>
        /// <param name="x">if the combo is new</param>
        /// <param name="orgPrice"> the orignial combo price</param>
        /// <param name="orgCalories"> the orignial combo calories</param>
        public void updateItem(IOrderItem item, int x, double orgPrice, uint orgCalories)
        {
            if (item.Price != orgPrice)
            {
                Price -= orgPrice;
                Price += item.Price;
                NotifyPropertyChanged("Price");
            }
            if (item.Calories != orgCalories)
            {
                _comboCalories -= orgCalories;
                _comboCalories += item.Calories;
                NotifyPropertyChanged("_totalCalories");
            }

            if (x == 1)
            {
                comboEntree = item;
                NotifyPropertyChanged("comboEntree");
                NotifyPropertyChanged("entreeName");
            }
            if (x == 2)
            {
                comboDrink = item;
                NotifyPropertyChanged("comboDrink");
                NotifyPropertyChanged("drinkName");
            }
            if (x == 3)
            {
                comboSide = item;
                NotifyPropertyChanged("comboSide");
                NotifyPropertyChanged("sideName");
            }

            showCombo();
        }

        /// <summary>
        /// adds the three things to combo
        /// </summary>
        /// <param name="item"> the item being added</param>
        /// <param name="x"> if the combo is new </param>
        public void addItem(IOrderItem item, int x)
        {
            Price += item.Price;
            NotifyPropertyChanged("Price");
            _comboCalories += item.Calories;
            NotifyPropertyChanged("_totalCalories");

            if (x == 1)
            {
                comboEntree = item;
                NotifyPropertyChanged("comboEntree");
                NotifyPropertyChanged("entreeName");
            }
            if (x == 2)
            {
                comboDrink = item;
                NotifyPropertyChanged("comboDrink");
                NotifyPropertyChanged("drinkName");
            }
            if (x == 3)
            {
                comboSide = item;
                NotifyPropertyChanged("comboSide");
                NotifyPropertyChanged("sideName");
            }

            editItem(item);
        }

        /// <summary>
        /// removes items from the combo
        /// </summary>
        /// <param name="x"> if the comob is new </param>
        /// <param name="orgPrice"> the original price for the item </param>
        /// <param name="orgCalories"> the original caloires for the item</param>
        public void removeItem(int x, double orgPrice, uint orgCalories)
        {
            Price -= orgPrice;
            NotifyPropertyChanged("Price");
            _comboCalories -= orgCalories;
            NotifyPropertyChanged("_totalCalories");

            if (x == 1)
            {
                comboEntree = null;
                NotifyPropertyChanged("comboEntree");
                NotifyPropertyChanged("entreeName");
            }
            if (x == 2)
            {
                comboDrink = null;
                NotifyPropertyChanged("comboDrink");
                NotifyPropertyChanged("drinkName");
            }
            if (x == 3)
            {
                comboSide = null;
                NotifyPropertyChanged("comboSide");
                NotifyPropertyChanged("sideName");
            }

            showCombo();
        }

        /// <summary>
        /// edits the item in the combo
        /// </summary>
        /// <param name="item"> said item to change </param>
        public void editItem(IOrderItem item)
        {
            entreeBorder.Child = null;
            drinkBorder.Child = null;
            sideBorder.Child = null;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;

            if (item.GetType() == typeof(BriarheartBurger))
            {
                editBorder.Child = new BriarheartBurgerCustomization(this, (BriarheartBurger)item);
            }
            else if (item.GetType() == typeof(DoubleDraugr))
            {
                editBorder.Child = new DoubleDraugrCustomization(this, (DoubleDraugr)item);
            }
            else if (item.GetType() == typeof(ThalmorTriple))
            {
                editBorder.Child = new ThalmorTripleCustomization(this, (ThalmorTriple)item);
            }
            else if (item.GetType() == typeof(SmokehouseSkeleton))
            {
                editBorder.Child = new SmokehouseSkeletonCustomization(this, (SmokehouseSkeleton)item);
            }
            else if (item.GetType() == typeof(GardenOrcOmelette))
            {
                editBorder.Child = new GardenOrcOmeletteCustomization(this, (GardenOrcOmelette)item);
            }
            else if (item.GetType() == typeof(PhillyPoacher))
            {
                editBorder.Child = new PhillyPoacherCustomization(this, (PhillyPoacher)item);
            }
            else if (item.GetType() == typeof(ThugsTBone))
            {
                editBorder.Child = new ThugsTBoneCustomization(this, (ThugsTBone)item);
            }

            else if (item.GetType() == typeof(SailorSoda))
            {
                editBorder.Child = new SailorSodaCustomization(this, (SailorSoda)item);
            }
            else if (item.GetType() == typeof(MarkarthMilk))
            {
                editBorder.Child = new MarkarthMilkCustomization(this, (MarkarthMilk)item);
            }
            else if (item.GetType() == typeof(AretinoAppleJuice))
            {
                editBorder.Child = new AretinoAppleJuiceCustomization(this, (AretinoAppleJuice)item);
            }
            else if (item.GetType() == typeof(CandlehearthCoffee))
            {
                editBorder.Child = new CandlehearthCoffeeCustomization(this, (CandlehearthCoffee)item);
            }
            else if (item.GetType() == typeof(WarriorWater))
            {
                editBorder.Child = new WarriorWaterCustomization(this, (WarriorWater)item);
            }

            else if (item.GetType() == typeof(VokunSalad))
            {
                editBorder.Child = new VokunSaladCustomization(this, (VokunSalad)item);
            }
            else if (item.GetType() == typeof(FriedMiraak))
            {
                editBorder.Child = new FriedMiraakCustomization(this, (FriedMiraak)item);
            }
            else if (item.GetType() == typeof(MadOtarGrits))
            {
                editBorder.Child = new MadOtarGritsCustomization(this, (MadOtarGrits)item);
            }
            else if (item.GetType() == typeof(DragonbornWaffleFries))
            {
                editBorder.Child = new DragonbornWaffleFriesCustomization(this, (DragonbornWaffleFries)item);
            }
        }



        /// <summary>
        /// Sends the current order and clears the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void editEntree(object sender, RoutedEventArgs e)
        {
            editItem(comboEntree);
        }

        /// <summary>
        /// Sends the current order and clears the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void editDrink(object sender, RoutedEventArgs e)
        {
            editItem(comboDrink);
        }

        /// <summary>
        /// Sends the current order and clears the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void editSide(object sender, RoutedEventArgs e)
        {
            editItem(comboSide);
        }

        /// <summary>
        /// Sends the current order and clears the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void removeCombo(object sender, RoutedEventArgs e)
        {
            curentOrder.removeCombo(orgPrice, orgCalories, newCombo);
        }

        /// <summary>
        /// Sends the current order and clears the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void confirmCombo(object sender, RoutedEventArgs e)
        {
            curentOrder.createCombo(comboEntree, comboDrink, comboSide, Price, _comboCalories, orgPrice, orgCalories, newCombo);
        }

        /// <summary>
        /// overrides the tostring to just say combo
        /// </summary>
        /// <returns> "Combo" </returns>
        public override string ToString()
        {
            return "Combo";
        }

        /// <summary>
        /// property of the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> everything = new List<string>();
                everything.Add(comboEntree.ToString());
                foreach (string change in comboEntree.SpecialInstructions)
                {
                    everything.Add("-" + change);
                }
                everything.Add(comboDrink.ToString());
                foreach (string change in comboDrink.SpecialInstructions)
                {
                    everything.Add("-" + change);
                }
                everything.Add(comboSide.ToString());
                foreach (string change in comboSide.SpecialInstructions)
                {
                    everything.Add("-" + change);
                }
                return everything;
            }
        }


        /// <summary>
        /// propery change
        /// </summary>
        /// <param name="propertyName"></param>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
