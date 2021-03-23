# <p align="center">(ReCapProject) / Araç Kiralama Sistemi </p>

BANNER

## Projenin İçeriği ve Amacı

- Bu proje SOLID prensiplerine uygun bir şekilde, eğitim tekrarı niteliğinde hazırlanmıştır.
- Proje Aspect'ler (Validation[FluentValidation], Transaction, Cache, Performance)  barındırmaktadır.
- JWT entegre edilmiştir ve Autofac desteği kullanılmıştır.

# İçindekiler
- 📦 [Kurulum](#kurulum)
- 💡  [Kullanım](#kullanım)
- 🗃 [Katmanlar](#katmanlar)
- 📄 [Tablolar](#tablolar)
- 📝 [Tabloların Kodları](#tabloların-kodları)

## KURULUM

## KULLANIM

## KATMANLAR
* 🗃 `Business`
  * 📁 `Abstract`
    * 📄 [IAuthService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/IAuthService.cs)
    * 📄 [IBrandService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/IBrandService.cs)
    * 📄 [ICarImageService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/ICarImageService.cs)
    * 📄 [ICarService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/ICarService.cs)
    * 📄 [ICategoryService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/ICategoryService.cs)
    * 📄 [IColorService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/IColorService.cs)
    * 📄 [ICustomerService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/ICustomerService.cs)
    * 📄 [IRentalService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/IRentalService.cs)
    * 📄 [IUserService.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Abstract/IUserService.cs)
  * 📁 `Concrete`
    * 📄 [AuthManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/AuthManager.cs)
    * 📄 [BrandManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/BrandManager.cs)
    * 📄 [CarImageManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/CarImageManager.cs)
    * 📄 [CarManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/CarManager.cs)
    * 📄 [CategoryManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/CategoryManager.cs)
    * 📄 [ColorManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/ColorManager.cs)
    * 📄 [CustomerManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/CustomerManager.cs)
    * 📄 [RentalManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/RentalManager.cs)
    * 📄 [UserManager.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Concrete/UserManager.cs)
  * 📁 `ValidationRules/FluentValidation`
    * 📄 [BrandValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs)
    * 📄 [CarImageValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/CarImageValidator.cs)
    * 📄 [CarValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs)
    * 📄 [CategoryValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/CategoryValidator.cs)
    * 📄 [ColorValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs)
    * 📄 [CustomerValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)
    * 📄 [RentalValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs)
    * 📄 [UserValidator.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs)
  * 📁 `BusinessAspects/Autofac`
    * 📄 [SecuredOperation.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs)
  * 📁 `DependencyResolvers/Autofac`
    * 📄 [AutofacBusinessModule.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)
  * 📁 `Constants`
    * 📄 [Messages.cs](https://github.com/bigidirmik/ReCapProject/blob/master/Business/Constants/Messages.cs)

* 🗃 `Core`
  * 📁 `Aspects/Autofac`
    * 📁 `Caching`
      * 📄 []()
      * 📄 []()
    * 📁 `Performance`
      * 📄 []()
    * 📁 `Transaction`
      * 📄 []()
    * 📁 `Validation`
      * 📄 []()
  * 📁 `CrossCuttingConcerns`
    * 📁 `Caching`
      * 📄 []()
      * 📁 `Microsoft`
        * 📄 []()
    * 📁 `Validation/FluentValidation`
      * 📄 []()
  * 📁 `DataAccess`
    * 📄 []()
    * 📁 `EntityFramework`
      * 📄 []()
  * 📁 `DependencyResolvers`
    * 📄 []()
  * 📁 `Entities`
    * 📄 []()
    * 📄 []()
    * 📁 `Concrete`
      * 📄 []()
      * 📄 []()
      * 📄 []()
  * 📁 `Extensions`
    * 📄 []()
    * 📄 []()
    * 📄 []()
  * 📁 `Utilities`
    * 📁 `Business`
      * 📄 []()
    * 📁 `Helpers`
      * 📄 []()
    * 📁 `Interceptors`
      * 📄 []()
      * 📄 []()
      * 📄 []()
    * 📁 `IoC`
      * 📄 []()
      * 📄 []()
    * 📁 `Results`
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
    * 📁 `Security`
      * 📁 `Encryption`
        * 📄 []()
        * 📄 []()
      * 📁 `Hashing`
        * 📄 []()
      * 📁 `JWT`
        * 📄 []()
        * 📄 []()
        * 📄 []()
        * 📄 []()
  
* 🗃 `DataAccess`
  * 📁 `Abstract`
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
  * 📁 `Concrete`
    * 📁 `EntityFramework`
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
      * 📄 []()
    
    
* 🗃 `Entities`
  * 📁 `Concrete`
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
  * 📁 `DTOs`
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()

* 🗃 `WebAPI`
  * 📄 []()
  * 📄 []()
  * 📄 []()
  * 📄 []()
  * 📄 []()
  * 📁 `Controllers`
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
    * 📄 []()
  * 📁 `Images`
    * 📄 []()
    * 📄 []()
  * 📁 `Properties`
    * 📄 []()
    
## TABLOLAR
## TABLOLARIN KODLARI
