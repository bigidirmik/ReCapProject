using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        // Added
        public static string CarAdded = "Araç eklendi!";
        public static string CategoryAdded = "Kategori eklendi!";
        public static string BrandAdded = "Marka eklendi!";
        public static string ColorAdded = "Renk eklendi!";
        public static string UserAdded = "Kullanıcı eklendi!";
        public static string CustomerAdded = "Şirket eklendi!";
        public static string RentalAdded = "Kiralama eklendi!";
        public static string CarImageAdded = "Araç görseli eklendi!";

        //Deleted
        public static string CarDeleted = "Araç silindi!";
        public static string CategoryDeleted = "Kategori silindi!";
        public static string BrandDeleted = "Marka silindi!";
        public static string ColorDeleted = "Renk silindi!";
        public static string UserDeleted = "Kullanıcı silindi!";
        public static string CustomerDeleted = "Şirket silindi!";
        public static string RentalDeleted = "Kiralama silindi!";
        public static string CarImageDeleted = "Araç görseli silindi!";

        //Updated
        public static string CarUpdated = "Araç güncellendi!";
        public static string CategoryUpdated = "Kategori güncellendi!";
        public static string BrandUpdated = "Marka güncellendi!";
        public static string ColorUpdated = "Renk güncellendi!";
        public static string UserUpdated = "Kullanıcı güncellendi!";
        public static string CustomerUpdated = "Şirket güncellendi!";
        public static string RentalUpdated = "Kiralama güncellendi!";
        public static string CarImageUpdated = "Araç görseli güncellendi!";

        //Listed
        public static string CarsListed = "Araçlar listelendi!";
        public static string CategoriesListed = "Kategoriler listelendi!";
        public static string BrandsListed = "Markalar listelendi!";
        public static string ColorsListed = "Renkler listelendi!";
        public static string UsersListed = "Kullanıcılar listelendi!";
        public static string CustomersListed = "Şirketler listelendi!";
        public static string RentalsListed = "Kiralamalar listelendi!";
        public static string CarImagesListed = "Araç görselleri listelendi!";

        //NotAdded and NotUpdated and Invalid)
        public static string CarInvalid = "Lütfen 2 karakterden uzun bir model adı ve 0'dan büyük ücret giriniz!";
        public static string CategoryInvalid = "Lütfen 2 karakterden uzun bir kategori adı giriniz!";
        public static string BrandInvalid = "Lütfen 2 karakterden uzun bir marka adı giriniz!";
        public static string ColorInvalid = "Lütfen 2 karakterden uzun bir renk giriniz!";
        public static string UserInvalid = "Lütfen 2 karakterden uzun bir isim giriniz!";
        public static string CustomerInvalid = "Lütfen 2 karakterden uzun bir şirket adı giriniz!";
        public static string RentalInvalid = "Bu araç henüz teslim edilmedi!";
        public static string CarImageLimitExceded = "Bir araç için yalnızca 5 adet resim yükleyebilirsiniz!";
        public static string CarImageCarIdEmpty = "Geçersiz ID!";
        public static string ImageNotFound = "Görsel bulunamadı!";

        //Maintenance
        public static string MaintenanceTime = "Sistem bakımda!";

        //Authorization
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kayıt olundu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Parola hatası!";
        public static string SuccessfulLogin = "Başarılı giriş!";
        public static string UserAlreadyExists = "Kullanıcı mevcut!";
        public static string AccessTokenCreated = "Token oluşturuldu!";
    }
}
