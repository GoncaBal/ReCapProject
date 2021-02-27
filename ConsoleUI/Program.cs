using System;
using System.Runtime.CompilerServices;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();
            //ColorTest();
            //CarDetailDtoTest();
        }

        private static void CarDetailDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + " " + car.DailyPrice + "TL");
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 4, ColorName = "Turuncu" });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Update(new Entities.Concrete.Car { CarId=7,CarName = "Panda", BrandId = 3, ColorId = 4, ModelYear = 2020, DailyPrice = 900, Description = "Otomatik vites" });
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}: {1} Model {2} {3} Günlük Ücret:{4} TL", car.CarId, car.ModelYear, car.BrandName, car.CarName, car.DailyPrice);
            }
        }
    }
}
