using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Entities.Concrete.Car { CarId=3,BrandId=1,ColorId=3,ModelYear=2020,DailyPrice=800,Description="BMW M5"});
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}: {1} Model {2} Günlük Ücret:{3}TL",car.CarId,car.ModelYear,car.Description,car.DailyPrice);
            }
        }
    }
}
