using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public bool Add(Car car)
        {
            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                return true;
            }
            else
            {
                Console.WriteLine("Araba adı 2 harften az olamaz/Günlük ücreti 0 TL ve daha az olamaz.");
                return false;
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public Car GetCarsByBrandId(int brandId)
        {
            return _carDal.Get(b => b.BrandId == brandId);
        }

        public Car GetCarsByColorId(int colorId)
        {
            return _carDal.Get(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

       
    }
}
