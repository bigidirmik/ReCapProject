using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Sedan"},
                new Category{CategoryId=2, CategoryName="Coupe"},
                new Category{CategoryId=3, CategoryName="Hatchback"},
                new Category{CategoryId=4, CategoryName="Van"},
                new Category{CategoryId=5, CategoryName="Pick-up"},
                new Category{CategoryId=6, CategoryName="Station Wagon"},
                new Category{CategoryId=7, CategoryName="Cabrio"},
                new Category{CategoryId=8, CategoryName="SUV"},
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c=>c.CategoryId==category.CategoryId);

            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);

            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
