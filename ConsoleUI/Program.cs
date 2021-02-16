﻿using Business.Concrete;
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
            GetCarDetailsTest();

            //CategoryManagerTest();
            //BrandManagerTest();
            //ColorManagerTest();
            //GetByTests(carManager);
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\tMarka" + "\t\t\t Model" + "\t\t\t\t\t\t   Kategori" + "\t\t    Ücret");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

                foreach (var car in result.Data)
                {
                    Console.WriteLine("\t" + car.BrandName + car.Description + car.CategoryName + car.DailyPrice + "\tTL\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void GetByTests(CarManager carManager)
        {
            foreach (var car in carManager.GetCarByCategoryId(4).Data)
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarByBrandId(7).Data)
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarByColorId(3).Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "\t" + color.ColorName);
            }
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + "\t" + brand.BrandName);
            }
        }

        private static void CategoryManagerTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryId + "\t" + category.CategoryName);
            }
        }
    }
}
