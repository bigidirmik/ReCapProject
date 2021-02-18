using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cust in context.Customers
                             join user in context.Users
                             on cust.UserId equals user.UserId

                             select new CustomerDetailDto
                             {
                                 CustomerId = cust.CustomerId,
                                 CompanyName = cust.CompanyName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 Password = user.Password
                             };
                return result.ToList();
            }
        }
    }
}
