using ReCap.Business.Concrete;
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
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }



        }
    }
}
