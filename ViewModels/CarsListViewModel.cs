using ShopVVK.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVVK.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { set; get; }
        public string currCategory { set; get; }
    }
}
