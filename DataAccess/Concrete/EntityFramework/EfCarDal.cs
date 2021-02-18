using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

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

                             join br in context.Brands
                             on car.BrandId equals br.BrandId

                             join col in context.Colors
                             on car.ColorId equals col.ColorId

                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CategoryName = cat.CategoryName,
                                 BrandName = br.BrandName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 ColorName = col.ColorName,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
