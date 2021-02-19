﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Entities.Concrete
{
    public class Car
    {
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description


        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public float DailyPrice { get; set; }
        public string Description { get; set; }




    }
}
