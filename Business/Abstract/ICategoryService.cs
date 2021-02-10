using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetCategoryById(int id);

        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
