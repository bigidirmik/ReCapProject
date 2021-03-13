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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cust in context.Customers
                             join user in context.Users
                             on cust.UserId equals user.Id

                             select new CustomerDetailDto
                             {
                                 CustomerId = cust.CustomerId,
                                 CompanyName = cust.CompanyName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 Password = Convert.ToString(user.PasswordHash) // JWT ile bozulmuştu, yanlış olabilir.
                             };
                return result.ToList();
            }
        }
    }
}
