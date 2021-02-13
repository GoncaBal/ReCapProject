using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear=2018,DailyPrice=85000,Description="2018 model Beyaz Audi"},
                new Car { Id = 2, BrandId = 1, ColorId = 2, ModelYear=2015,DailyPrice=60000,Description="2015 model Siyah Audi"},
                new Car { Id = 3, BrandId = 2, ColorId = 3, ModelYear=2009,DailyPrice=45000,Description="2009 model Kırmızı Bmw"},
                new Car { Id = 4, BrandId = 2, ColorId = 1, ModelYear=2018,DailyPrice=90000,Description="2018 model Beyaz Bmw"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
            
        }

        public List<Car> GetAllById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

      
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
