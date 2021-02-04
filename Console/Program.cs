using Business.Concrate;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car { carId = 5,ColorId=1, BrandId = 2, ModelYear = 2008, DailyPrice = 220, Description = "Manual Gear" };
            carManager.Add(car1);

            foreach (var item in carManager.GetAll())
            {
                System.Console.WriteLine(item.ColorId);
            }
            
        }
    }
}
