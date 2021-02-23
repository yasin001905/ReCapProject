using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstrack
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int colorId);
    }
}
