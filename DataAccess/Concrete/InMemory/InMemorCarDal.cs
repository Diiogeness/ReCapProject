using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemorCarDal : IInMemoryCarDal
    {
        List<Car> cars;
        public InMemorCarDal()
        {
            
            //Yerel Hafıza 
            cars = new List<Car>()
            {
                new Car{CarId=1,CarName="BMW",ColorId=1,BrandId=1,DailyPrice=1200,ModelYear=2015,Description="Auto and 4x4"},
                new Car{CarId=2,CarName="Audi",ColorId=2,BrandId=2,DailyPrice=1300,ModelYear=2019,Description="Manuel and 4x4"},
                new Car{CarId=3,CarName="Ferrari",ColorId=3,BrandId=3,DailyPrice=2500,ModelYear=2019,Description="Auto , Turbo"},
                new Car{CarId=4,CarName="Honda",ColorId=4,BrandId=4,DailyPrice=800,ModelYear=2020,Description="Manuel"},
                new Car{CarId=5,CarName="Toyata",ColorId=5,BrandId=5,DailyPrice=800,ModelYear=2018,Description="Manuel and 4x4"},
            };
        }
       

       
        public void Add(Car car)
        {
            cars.Add(car);
            Console.WriteLine(car.CarName+" Added!!");
        }

        public void Delete(Car car)
        {
            cars.Remove(car);
            Console.WriteLine(car.CarName + " Deleted!!");
        }

        public List<Car> GetAll()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.CarName);
            }
            return cars;
        }

        public List<Car> GetById(int CarId)
        {
            foreach (var car in cars)
            {
                if (car.CarId==CarId)
                {
                    Console.WriteLine(car.CarId);
                }
            }

            return cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(c => c.CarId == car.CarId);
            car.CarId = carToUpdate.CarId;
            car.BrandId = carToUpdate.BrandId;
            car.CarName = carToUpdate.CarName;
            car.ColorId = carToUpdate.ColorId;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.Description = carToUpdate.Description;
            car.ModelYear = carToUpdate.ModelYear;
            Console.WriteLine(car.CarName+" Updated!!");
        }
    }
}
