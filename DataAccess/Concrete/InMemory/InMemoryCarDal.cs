﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal 
    //: ICarDal
{
    List<Car> _cars;

    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
            new Car
            {
                Id = 1,
                BrandId=1,
                ColorId=1,
                ModelYear= 2017,
                DailyPrice=1500,
                Description="BMW i3"
            },
            new Car
            {
                Id = 2,
                BrandId=1,
                ColorId=2,
                ModelYear= 2019,
                DailyPrice=1800,
                Description="BMW i5"
            },
            new Car
            {
                Id = 3,
                BrandId=2,
                ColorId=4,
                ModelYear= 2020,
                DailyPrice=1250,
                Description="AUDI A8 Long"
            },
            new Car
            {
                Id = 4,
                BrandId=3,
                ColorId=1,
                ModelYear= 2021,
                DailyPrice=1800,
                Description="OPEL Mokka"
            },
            new Car
            {
                Id = 5,
                BrandId=3,
                ColorId=2,
                ModelYear= 2024,
                DailyPrice=800,
                Description="OPEL Corsa"
            },
        };
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
        //Car carToDelete = _cars.FirstOrDefault(c => c.Id == car.Id);

        //_cars.Remove(carToDelete);
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

    public List<Car> GetCarById(int id)
    {
        return _cars.Where(c => c.Id == id).ToList();
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.Description = car.Description;
    }
}
