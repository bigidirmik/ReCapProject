﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetColorById(int id);

        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}