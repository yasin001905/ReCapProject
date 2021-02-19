using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.DAL.Abstrack
{
    public interface IColorDal
    {
        List<Color> GetAll();
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
