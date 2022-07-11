using ShopVVK.Data.Interfaces;
using ShopVVK.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVVK.Data.Repository
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
               {
                   new Category {categoryName = "Электромобили", desc = "современный вид транспорта"},
                   new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания"}
               };



            }
        }
      
    }
}
