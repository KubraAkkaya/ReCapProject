using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> { 
            new Car{carId=1,BrandId=2,ColorId=2,ModelYear=2001,DailyPrice=300,Description="Manual Gear"},
            new Car{carId=2,BrandId=2,ColorId=3,ModelYear=2021,DailyPrice=870,Description="Ideal For The Long Way"},
            new Car{carId=3,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=425,Description="Automatic Gear"},
            new Car{carId=4,BrandId=3,ColorId=2,ModelYear=1975,DailyPrice=530,Description="Classic Car"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=>c.carId==car.carId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            var expression = filter.Compile();
            var car = _car.SingleOrDefault(expression);
            return car;
        }     

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            var expression = filter.Compile();
            return filter == null ? _car : _car.Where(expression).ToList();
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c => c.carId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return null;//Burada SQL işlemlri olmaz.
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.carId == car.carId);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
        }
    }
}
