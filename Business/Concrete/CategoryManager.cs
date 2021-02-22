using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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


        public IResult Add(Category category)
        {
            if (category.CategoryName.Length>2)
            {
                _categoryDal.Add(category);
                return new SuccessResult(Messages.CategoryAdded);
            }
            else
            {
                return new ErrorResult(Messages.CategoryInvalid);
            }
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.CategoriesListed);
        }

        public IDataResult<Category> GetCategoryById(int categoryId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Category>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Category>(_categoryDal.Get(cat => cat.CategoryId == categoryId));
        }

        public IResult Update(Category category)
        {
            if (category.CategoryName.Length > 2)
            {
                _categoryDal.Update(category);
                return new SuccessResult(Messages.CategoryUpdated);
            }
            else
            {
                return new ErrorResult(Messages.CategoryInvalid);
            }
        }
    }
}
