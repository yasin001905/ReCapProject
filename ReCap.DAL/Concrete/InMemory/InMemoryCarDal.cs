using ReCap.DAL.Abstrack;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    CarId=1, BrandId=1, ColorId= 1, DailyPrice= 150, ModelYear= "1999", Description= "sdfsdfsdfsdf"
                },
                new Car
                {
                    CarId=2, BrandId=2, ColorId= 2, DailyPrice= 500, ModelYear= "2010", Description= "sdfsdfsdfsdf"
                },
                new Car
                {
                    CarId=3, BrandId=2, ColorId= 1, DailyPrice= 350, ModelYear= "2005", Description= "sdfsdfsdfsdf"
                },
                new Car
                {
                    CarId=4, BrandId=1, ColorId= 3, DailyPrice= 200, ModelYear= "2002", Description= "sdfsdfsdfsdf"
                }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars; 
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
