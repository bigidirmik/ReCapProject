using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);

            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);
        }

        public IDataResult<Color> GetColorById(int colorId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Color>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Color>(_colorDal.Get(col => col.ColorId == colorId));
        }

        public IResult Update(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);

            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
