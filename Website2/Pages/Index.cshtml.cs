using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string SearchTerms { get; set; }
        public IEnumerable<IOrderItem> EntreeMenu { get; set; }
        public IEnumerable<IOrderItem> DrinkMenu { get; set; }
        public IEnumerable<IOrderItem> SideMenu { get; set; }

        public string[] foodTypes
        {
            get => new string[]
            {
                "Entrees",
                "Drinks",
                "Sides"
            };
        }
        public string[] selectedFoodTypes { get; set; }
        public double? PriceMin { get; set; }
        public double? PriceMax { get; set; }
        public double? CaloriesMin { get; set; }
        public double? CaloriesMax { get; set; }


        public void OnGet(string SearchTerms, string[] selectedFoodTypes, double? PriceMin, double? PriceMax, double? CaloriesMin, double? CaloriesMax)
        {
            this.SearchTerms = SearchTerms;
            this.selectedFoodTypes = selectedFoodTypes;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;

            if (selectedFoodTypes.Contains("Entrees") || selectedFoodTypes.Count() == 0)
            {
                EntreeMenu = Menu.Entrees();
                if (SearchTerms != null) EntreeMenu = EntreeMenu.Where(item => item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
                EntreeMenu = EntreeMenu.Where(item => item.Price >= ((PriceMin == null) ? 0 : PriceMin) && item.Price <= ((PriceMax == null) ? 10 : PriceMax));
                EntreeMenu = EntreeMenu.Where(item => item.Calories >= ((CaloriesMin == null) ? 0 : CaloriesMin) && item.Calories <= ((CaloriesMax == null) ? 1000 : CaloriesMax));

                //EntreeMenu = Menu.Search(SearchTerms, 1);
                //EntreeMenu = Menu.FilterByPrice(EntreeMenu, PriceMin, PriceMax);
                //EntreeMenu = Menu.FilterByCalorie(EntreeMenu, CaloriesMin, CaloriesMax);
            }
            else EntreeMenu = Enumerable.Empty<IOrderItem>();


            if (selectedFoodTypes.Contains("Drinks") || selectedFoodTypes.Count() == 0)
            {
                DrinkMenu = Menu.Drinks();
                if (SearchTerms != null) DrinkMenu = DrinkMenu.Where(item => item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
                DrinkMenu = DrinkMenu.Where(item => item.Price >= ((PriceMin == null) ? 0 : PriceMin) && item.Price <= ((PriceMax == null) ? 10 : PriceMax));
                DrinkMenu = DrinkMenu.Where(item => item.Calories >= ((CaloriesMin == null) ? 0 : CaloriesMin) && item.Calories <= ((CaloriesMax == null) ? 1000 : CaloriesMax));

                //DrinkMenu = Menu.Search(SearchTerms, 2);
                //DrinkMenu = Menu.FilterByPrice(DrinkMenu, PriceMin, PriceMax);
                //DrinkMenu = Menu.FilterByCalorie(DrinkMenu, CaloriesMin, CaloriesMax);
            }
            else DrinkMenu = Enumerable.Empty<IOrderItem>();

            if (selectedFoodTypes.Contains("Sides") || selectedFoodTypes.Count() == 0)
            {
                SideMenu = Menu.Sides();
                if (SearchTerms != null) SideMenu = SideMenu.Where(item => item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
                SideMenu = SideMenu.Where(item => item.Price >= ((PriceMin == null) ? 0 : PriceMin) && item.Price <= ((PriceMax == null) ? 10 : PriceMax));
                SideMenu = SideMenu.Where(item => item.Calories >= ((CaloriesMin == null) ? 0 : CaloriesMin) && item.Calories <= ((CaloriesMax == null) ? 1000 : CaloriesMax));

                //SideMenu = Menu.Search(SearchTerms, 3);
                //SideMenu = Menu.FilterByPrice(SideMenu, PriceMin, PriceMax);
                //SideMenu = Menu.FilterByCalorie(SideMenu, CaloriesMin, CaloriesMax);
            }
            else SideMenu = Enumerable.Empty<IOrderItem>();
        }
    }
}
