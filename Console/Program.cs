using Business.Concrate;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;
using DataAccess.Concrate.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //CustomerTest();
           
        }

        private static void CustomerTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { Id = 1, CompanyName = "A Şirketi" });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.DailyPrice);
    
                }
            }
            else{ Console.WriteLine(result.Message);}

           
        }
    }
}
