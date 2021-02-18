using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from re in context.Rentals

                             join cr in context.Cars
                             on re.CarId equals cr.CarId

                             join ct in context.Categories
                             on cr.CategoryId equals ct.CategoryId

                             join br in context.Brands
                             on cr.BrandId equals br.BrandId

                             join co in context.Colors
                             on cr.ColorId equals co.ColorId

                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId

                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarId = cr.CarId,
                                 CategoryName = ct.CategoryName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 CompanyName = cu.CompanyName,
                                 ModelYear = cr.ModelYear,
                                 Description = cr.Description
                             };
                return result.ToList();
            }
        }
    }
}
