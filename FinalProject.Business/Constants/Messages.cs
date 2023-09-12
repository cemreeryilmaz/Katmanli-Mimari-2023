using FinalProject.Core.Entities.Concrete;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi.";
        public static string UnitPriceInvalid = "Fiyat 0'dan küçük olmamalıdır.";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün vardır.";
        public static string CheckIfCategoryLimitExceded = "Kategori Limiti aşıldığı için yeni ürün eklenemez.";
        public static string? AuthorizationDenied="Yetkiniz Yok.";
        public static string UserRegistered = "Kayıt Oldu.";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
    }
}
