using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Id, BrandId, ColorId, ModelYear, DailyPrice, Description
    public class Car : ICarManager
    {
        public string CarName { get; set; }
        public int CarId{ get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
