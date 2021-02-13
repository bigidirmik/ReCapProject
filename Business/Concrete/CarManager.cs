using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç eklendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir model adı ve 0'dan büyük ücret giriniz!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araç silindi!");
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("\nAraçlar:\n");
            return _carDal.GetAll();
        }

        public List<Car> GetCarByBrandId(int brandId)
        {
            Console.WriteLine("\nMarka ID'si {0} olan araçlar:\n", brandId);
            return _carDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetCarByCategoryId(int categoryId)
        {
            Console.WriteLine("\nKategori ID'si {0} olan araçlar:\n", categoryId);
            return _carDal.GetAll(car => car.CategoryId == categoryId);
        }

        public List<Car> GetCarByColorId(int colorId)
        {
            Console.WriteLine("\nRenk ID'si {0} olan araçlar:\n", colorId);
            return _carDal.GetAll(car => car.ColorId == colorId);
        }

        public List<Car> GetCarByDailyPrice(decimal min, decimal max)
        {
            Console.WriteLine("\nGünlük fiyatı {0} - {1} TL arası olan araçlar:\n",min,max);
            return _carDal.GetAll(car => car.DailyPrice >= min && car.DailyPrice <= max);
        }

        public Car GetCarById(int id)
        {
            Console.WriteLine("\nID'si {0} olan araç:\n", id);
            return _carDal.Get(car => car.CarId == id);
        }

        public List<Car> GetCarByModelYear(int min,int max)
        {
            Console.WriteLine("\nModel yılları {0} - {1} arası olan araçlar:\n", min, max);
            return _carDal.GetAll(car => car.ModelYear >= min && car.ModelYear <= max);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Araç güncellendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir model adı ve 0'dan büyük ücret giriniz!");
            }
        }
    }
}
