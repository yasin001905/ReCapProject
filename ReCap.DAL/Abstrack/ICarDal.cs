using ReCap.Core.DataAccess;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.DAL.Abstrack
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
