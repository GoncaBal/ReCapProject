using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _color;

        public ColorManager(IColorDal color)
        {
            _color = color;
        }

        public void Add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
            _color.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _color.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _color.Get(c=>c.ColorId==colorId);
        }

        public void Update(Color color)
        {
            _color.Update(color);
        }
    }
}
