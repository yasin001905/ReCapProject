using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstrack
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int brandId);
    }
}
