using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars

                             join cat in context.Categories
                             on car.CategoryId equals cat.CategoryId

                             join brn in context.Brands
                             on car.BrandId equals brn.BrandId

                             join clr in context.Colors
                             on car.ColorId equals clr.ColorId

                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CategoryName = cat.CategoryName,
                                 BrandName = brn.BrandName,
                                 ColorName = clr.ColorName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 ImagePath = (from cImg in context.CarImages where cImg.CarId == car.CarId select cImg.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId) 
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars.Where(car=>car.BrandId == brandId)

                             join cat in context.Categories
                             on car.CategoryId equals cat.CategoryId

                             join brn in context.Brands
                             on car.BrandId equals brn.BrandId

                             join clr in context.Colors
                             on car.ColorId equals clr.ColorId

                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CategoryName = cat.CategoryName,
                                 BrandName = brn.BrandName,
                                 ColorName = clr.ColorName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 ImagePath = (from cImg in context.CarImages where cImg.CarId == car.CarId select cImg.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars.Where(car => car.ColorId == colorId)

                             join cat in context.Categories
                             on car.CategoryId equals cat.CategoryId

                             join brn in context.Brands
                             on car.BrandId equals brn.BrandId

                             join clr in context.Colors
                             on car.ColorId equals clr.ColorId

                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CategoryName = cat.CategoryName,
                                 BrandName = brn.BrandName,
                                 ColorName = clr.ColorName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 ImagePath = (from cImg in context.CarImages where cImg.CarId == car.CarId select cImg.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByCarId(int carId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars.Where(car => car.CarId == carId)

                             join cat in context.Categories
                             on car.CategoryId equals cat.CategoryId

                             join brn in context.Brands
                             on car.BrandId equals brn.BrandId

                             join clr in context.Colors
                             on car.ColorId equals clr.ColorId

                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CategoryName = cat.CategoryName,
                                 BrandName = brn.BrandName,
                                 ColorName = clr.ColorName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 ImagePath = (from cImg in context.CarImages where cImg.CarId == car.CarId select cImg.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByCategoryId(int categoryId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars.Where(car => car.CategoryId == categoryId)

                             join cat in context.Categories
                             on car.CategoryId equals cat.CategoryId

                             join brn in context.Brands
                             on car.BrandId equals brn.BrandId

                             join clr in context.Colors
                             on car.ColorId equals clr.ColorId

                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CategoryName = cat.CategoryName,
                                 BrandName = brn.BrandName,
                                 ColorName = clr.ColorName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 ImagePath = (from cImg in context.CarImages where cImg.CarId == car.CarId select cImg.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }
    }
}
