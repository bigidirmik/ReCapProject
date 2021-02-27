using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customer> GetCustomerById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Customer>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == id));
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CustomerDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails(filter), Messages.CustomersListed);
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
