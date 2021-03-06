using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
    }
}
