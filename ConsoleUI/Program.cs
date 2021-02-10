using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("\n\t" + "----Model----" + "\t\t\t\t\t" + "----Günlük ücret----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + "\t" + car.Description + "\t" + car.DailyPrice + " TL");
            }


            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryId + "\t" + category.CategoryName);
            }


            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + "\t" + brand.BrandName);
            }


            ColorManager colorManager = new ColorManager(new EfColorDal());
            
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "\t" + color.ColorName);
            }

            foreach (var car in carManager.GetCarByCategoryId(4))
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarByBrandId(7))
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarByColorId(3))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
