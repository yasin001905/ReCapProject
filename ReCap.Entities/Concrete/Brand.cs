using ReCap.Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Entities.Concrete
{
   public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
