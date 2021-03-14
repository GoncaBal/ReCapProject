using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars join b in context.Brands on c.BrandId equals b.BrandId join co in context.Colors on c.ColorId equals co.ColorId select new CarDetailDto {CarId=c.CarId,CarName=c.CarName,BrandName=b.BrandName, ModelYear=c.ModelYear,ColorName=co.ColorName,DailyPrice=c.DailyPrice};
                return result.ToList();
            }
        }
    }
}
