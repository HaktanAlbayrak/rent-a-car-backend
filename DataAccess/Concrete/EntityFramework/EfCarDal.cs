﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (CarDbContext context = new CarDbContext())
        {
            var result = from c in context.Cars
                         join b in context.Brands
                         on c.BrandId equals b.Id
                         join clr in context.Colors
                         on c.ColorId equals clr.Id
                         select new CarDetailDto
                         {
                             CarId = c.Id,
                             CarName = c.Description,
                             BrandName = b.Name,
                             ColorName = clr.Name,
                             DailyPrice = c.DailyPrice
                         };
            return result.ToList();
        }
    }
}