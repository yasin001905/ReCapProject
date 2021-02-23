using ReCap.Core.DataAccess.EntityFramework;
using ReCap.DAL.Abstrack;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCap.DAL.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {

    }
}
