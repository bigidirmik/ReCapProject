using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                // Sedan
                new Car{CategoryId=1, CarId=1, BrandId=3, ColorId=6, ModelYear=2015, DailyPrice=120, Description="Fiat Egea"},
                new Car{CategoryId=1, CarId=2, BrandId=10, ColorId=7, ModelYear=2017, DailyPrice=100, Description="Renault Megan"},

                // Coupe
                new Car{CategoryId=2, CarId=3, BrandId=5, ColorId=1, ModelYear=2016, DailyPrice=230, Description="Mercedes-Benz E300 AMG"},
                new Car{CategoryId=2, CarId=4, BrandId=1, ColorId=5, ModelYear=2018, DailyPrice=250, Description="BMW 420d xDrive M Sport"},

                // Hatchback
                new Car{CategoryId=3, CarId=5, BrandId=10, ColorId=3, ModelYear=2016, DailyPrice=170, Description="Renault Clio"},
                new Car{CategoryId=3, CarId=6, BrandId=11, ColorId=4, ModelYear=2012, DailyPrice=80, Description="Toyota Corolla"},

                // Van
                new Car{CategoryId=4, CarId=7, BrandId=4, ColorId=1, ModelYear=2013, DailyPrice=350, Description="Ford Transit"},
                new Car{CategoryId=4, CarId=8, BrandId=4, ColorId=2, ModelYear=2014, DailyPrice=360, Description="Ford Tourneo Courier"},
                new Car{CategoryId=4, CarId=9, BrandId=3, ColorId=3, ModelYear=2019, DailyPrice=330, Description="Fiat Fiorino Combi"},

                // Pickup
                new Car{CategoryId=5, CarId=10, BrandId=4, ColorId=2, ModelYear=2014, DailyPrice=310, Description="Ford Transit"},
                new Car{CategoryId=5, CarId=11, BrandId=6, ColorId=5, ModelYear=2015, DailyPrice=320, Description="Mitsubishi L200 4x2"},
                new Car{CategoryId=5, CarId=12, BrandId=5, ColorId=2, ModelYear=2017, DailyPrice=350, Description="Mercedes-Benz x250d Prograssive"},

                // Station Wagon
                new Car{CategoryId=6, CarId=13, BrandId=2, ColorId=5, ModelYear=2016, DailyPrice=120, Description="Dacia Logan 1.6 MCV Ambiance"},
                new Car{CategoryId=6, CarId=14, BrandId=12, ColorId=6, ModelYear=2017, DailyPrice=170, Description="Volkswagen Passat"},

                // Cabrio
                new Car{CategoryId=7, CarId=15, BrandId=1, ColorId=5, ModelYear=2019, DailyPrice=450, Description="BMW Z4 2.5"},
                new Car{CategoryId=7, CarId=16, BrandId=8, ColorId=8, ModelYear=2020, DailyPrice=320, Description="Peugeot 206 1.6"},

                // SUV
                new Car{CategoryId=8, CarId=17, BrandId=9, ColorId=1, ModelYear=2017, DailyPrice=470, Description="Range Rover Autobiography 3.0 Diesel"},
                new Car{CategoryId=8, CarId=18, BrandId=7, ColorId=3, ModelYear=2019, DailyPrice=390, Description="Nissan Qashqai 1.6 DCI Diesel"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
