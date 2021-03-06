﻿using ReCap.DAL.Abstrack;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReCap.DAL.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1, BrandId=1, ColorId= 1, DailyPrice= 150, ModelYear= 1999, Description= "sdfsdfsdfsdf"
                },
                new Car
                {
                   Id = 1, BrandId=2, ColorId= 2, DailyPrice= 500, ModelYear= 2010, Description= "sdfsdfsdfsdf"
                },
                new Car
                {
                   Id = 1, BrandId=2, ColorId= 1, DailyPrice= 350, ModelYear= 2005, Description= "sdfsdfsdfsdf"
                },
                new Car
                {
                   Id = 1, BrandId=3, ColorId= 3, DailyPrice= 200, ModelYear= 2002, Description= "sdfsdfsdfsdf"
                }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars; 
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
