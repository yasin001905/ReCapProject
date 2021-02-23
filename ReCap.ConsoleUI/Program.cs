using ReCap.Business.Concrete;
using ReCap.DAL.Concrete.EntityFramework;
using ReCap.DAL.Concrete.InMemory;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ReCap.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(45000,50000))
            {
                Console.WriteLine(car.Description);
            }



        }
    }
}
