using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetCarById(int id);
        List<Car> GetCarsByColorId(int colarId);
        List<Car> GetCarsByBrandId(int brandId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
