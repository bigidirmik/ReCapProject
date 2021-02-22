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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in filter == null ? context.Cars : context.Cars.Where(filter)

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
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
