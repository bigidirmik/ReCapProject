using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car GetCarById(int id);
        List<Car> GetCarByCategoryId(int categoryId);
        List<Car> GetCarByBrandId(int brandId);
        List<Car> GetCarByColorId(int colorId);

        List<Car> GetCarByModelYear(int min,int max);
        List<Car> GetCarByDailyPrice(decimal min,decimal max);

        List<CarDetailDto> GetCarDetails();

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
