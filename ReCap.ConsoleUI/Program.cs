﻿using ReCap.Business.Concrete;
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
            CarTest();

            //ColorTest();





        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " / "+ car.BrandName);
            }
        }
    }
}
