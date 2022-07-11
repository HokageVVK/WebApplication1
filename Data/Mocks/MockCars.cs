using ShopVVK.Data.Interfaces;
using ShopVVK.Data.Models;
using ShopVVK.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVVK.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCar = new MockCategory();   
        public IEnumerable<Car> Cars
        { 
           get {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCar.AllCategories.First()
                    },

                     new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для горордской жизни",
                        img = "/img/ford.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCar.AllCategories.Last()
                    },

                      new Car {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Если ты не лох BMW M3 купи на пох",
                        img = "/img/bmw.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCar.AllCategories.Last()
                    },

                       new Car {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Мерседес купил мужик и теперь летишь как вжик",
                        img = "/img/mercedes.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCar.AllCategories.Last()
                    },

                        new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Купите меня пожалуйста",
                        longDesc = "Ты действительно меня купишь... Зачем, а главное почему?",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCar.AllCategories.First()
                    },
                };  
           }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
