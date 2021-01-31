using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                BrandId = 6,
                CarId = 6,
                CarName = "Tofaşkk :D",
                ColorId = 4,
                DailyPrice = 1000,
                Description = "1.9 Turbo Dizel",
                ModelYear = 1994
            };
            Car car2 = new Car()
            {
                CarName = "Skoda",
                CarId = 7,
                ColorId = 3,
                DailyPrice=700,
                Description="Auto and 4x4",
                ModelYear=2017,
                BrandId=8
               

            };



            InMemorCarDal ınMemoryCarDal = new InMemorCarDal();
            ınMemoryCarDal.Add(car1);
            ınMemoryCarDal.Add(car2);
            ınMemoryCarDal.Update(car1);
            Console.WriteLine("------------------");
            Console.Write("İstediğiniz arabanın ıd numarası:");
            ınMemoryCarDal.GetById(car2.CarId);
            Console.WriteLine("------------------");
            ınMemoryCarDal.GetAll();
            Console.WriteLine("------------------");
            ınMemoryCarDal.Delete(car1);
            ınMemoryCarDal.Delete(car2);
            ınMemoryCarDal.GetAll();
            
        }
    }
}
