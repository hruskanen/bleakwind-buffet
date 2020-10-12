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
        Order curentOrder;

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


        private double _ComboTotal = 0;
        public double _comboTotal
        {
            get { return _ComboTotal; }
            set
            {
                if (_ComboTotal != value)
                {
                    _ComboTotal = value;
                    NotifyPropertyChanged("_comboTotal");
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

        bool newCombo = true;
        double orgPrice;
        uint orgCalories;

        public Combo(Order order, List<IOrderItem> combo)
        {
            if (combo[0] != null && combo[1] != null && combo[2] != null)
            {
                orgPrice = combo[0].Price + combo[1].Price + combo[2].Price;
                _comboTotal = combo[0].Price + combo[1].Price + combo[2].Price;
                NotifyPropertyChanged("_comboTotal");
                orgCalories = combo[0].Calories + combo[1].Calories + combo[2].Calories;
                _comboCalories = combo[0].Calories + combo[1].Calories + combo[2].Calories;
                NotifyPropertyChanged("_comboCalories");
                newCombo = false;
            }
            comboEntree = combo[0];
            NotifyPropertyChanged("comboEntree");
            comboDrink = combo[1];
            NotifyPropertyChanged("comboDrink");
            comboSide = combo[2];
            NotifyPropertyChanged("comboSide");

            this.curentOrder = order;
            InitializeComponent();
            showCombo();
        }

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

        public void updateItem(IOrderItem item, int x, double orgPrice, uint orgCalories)
        {
            if (item.Price != orgPrice)
            {
                _comboTotal -= orgPrice;
                _comboTotal += item.Price;
                NotifyPropertyChanged("_comboTotal");
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

        public void addItem(IOrderItem item, int x)
        {
            _comboTotal += item.Price;
            NotifyPropertyChanged("_comboTotal");
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

        public void removeItem(int x, double orgPrice, uint orgCalories)
        {
            _comboTotal -= orgPrice;
            NotifyPropertyChanged("_comboTotal");
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
            curentOrder.createCombo(comboEntree, comboDrink, comboSide, _comboTotal, _comboCalories, orgPrice, orgCalories, newCombo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
