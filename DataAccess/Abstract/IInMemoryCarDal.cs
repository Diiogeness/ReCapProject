using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{

    //InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

    public interface IInMemoryCarDal
    {
        List<Car> GetById(int CarId);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
