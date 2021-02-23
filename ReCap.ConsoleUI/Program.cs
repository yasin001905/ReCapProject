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
            //CarTest();

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(45000, 50000))
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
