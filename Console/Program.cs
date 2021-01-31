using Business.Concrate;
using DataAccess.Concrate.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ColorId);
            }
            
        }
    }
}
