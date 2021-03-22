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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails() // rentaldal, controller, service, manager normalde filtre için bu kodu içeriyor, ancak postman deserialization hatası veriyor. ve manager'da add kısmında rental kontrolü yaptığımız add metodu da hata veriyor
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from rnt in context.Rentals //filter == null ? context.Rentals : context.Rentals.Where(filter) üstteki expression kodu için bu şekilde

                             join car in context.Cars
                             on rnt.CarId equals car.CarId

                             join cat in context.Categories
                             on car.CategoryId equals cat.CategoryId

                             join brn in context.Brands
                             on car.BrandId equals brn.BrandId

                             join clr in context.Colors
                             on car.ColorId equals clr.ColorId

                             join cus in context.Customers
                             on rnt.CustomerId equals cus.CustomerId

                             join usr in context.Users
                             on cus.UserId equals usr.Id


                             select new RentalDetailDto
                             {
                                 RentalId = rnt.RentalId,
                                 CarId = car.CarId,
                                 CategoryName = cat.CategoryName,
                                 BrandName = brn.BrandName,
                                 ColorName = clr.ColorName,
                                 CompanyName = cus.CompanyName,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 UserName = usr.FirstName + " " + usr.LastName, 
                                 CustomerName = cus.CompanyName,
                                 RentDate = rnt.RentDate,
                                 ReturnDate = rnt.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
