using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            if (color.ColorName.Length > 2)
            {
                _colorDal.Add(color);
                Console.WriteLine("Renk eklendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir renk giriniz!");
            }
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk silindi!");
        }

        public List<Color> GetAll()
        {
            Console.WriteLine("\nRenkler:\n");
            return _colorDal.GetAll();
        }

        public Color GetColorById(int id)
        {
            Console.WriteLine("\nID'si {0} olan renk:\n", id);
            return _colorDal.Get(col => col.ColorId == id);
        }

        public void Update(Color color)
        {
            if (color.ColorName.Length > 2)
            {
                _colorDal.Update(color);
                Console.WriteLine("Renk güncellendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir renk giriniz!");
            }
        }
    }
}
