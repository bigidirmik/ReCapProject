using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetCarById(int carId);
        IDataResult<List<Car>> GetCarByCategoryId(int categoryId);
        IDataResult<List<Car>> GetCarByBrandId(int brandId);
        IDataResult<List<Car>> GetCarByColorId(int colorId);

        IDataResult<List<Car>> GetCarByModelYear(int min,int max);
        IDataResult<List<Car>> GetCarByDailyPrice(decimal min,decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IResult AddTransactionalTest(Car car);
    }
}
