using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            if (category.CategoryName.Length>2)
            {
                _categoryDal.Add(category);
                Console.WriteLine("Kategori eklendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir kategori adı giriniz!");
            }
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
            Console.WriteLine("Kategori silindi!");
        }

        public List<Category> GetAll()
        {
            Console.WriteLine("\nKategoriler:\n");
            return _categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            Console.WriteLine("\nID'si {0} olan kategori:\n", id);
            return _categoryDal.Get(cat => cat.CategoryId == id);
        }

        public void Update(Category category)
        {
            if (category.CategoryName.Length > 2)
            {
                _categoryDal.Update(category);
                Console.WriteLine("Kategori güncellendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir kategori adı giriniz!");
            }
        }
    }
}
