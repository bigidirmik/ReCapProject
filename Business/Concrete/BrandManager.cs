using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka eklendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir marka adı giriniz!");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka silindi!");
        }

        public List<Brand> GetAll()
        {
            Console.WriteLine("\nMarkalar:\n");
            return _brandDal.GetAll();
        }

        public Brand GetBrandById(int id)
        {
            Console.WriteLine("\nID'si {0} olan marka:\n", id);
            return _brandDal.Get(br => br.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka güncellendi!");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir marka adı giriniz!");
            }
        }
    }
}
