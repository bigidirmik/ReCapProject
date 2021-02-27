using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        IRentalDal _rentalDal;
        
        public RentalValidator(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public RentalValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.CustomerId).NotEmpty();
            RuleFor(c => c.RentDate).NotEmpty();
        }
    }
}
