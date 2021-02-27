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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenaceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isme sahip bir ürün zaten bulunmakta";
        public static string CategoryLimitExceeded = "Kategori Limiti Aşıldı";
        public static string  AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = " kayıt oldu";
        public static string UserNotFound = "bulunamadı";
        public static string PasswordError = "şifre hatalı";
        public static string SuccessfulLogin = "giriş yapıldı";
        public static string UserAlreadyExists = "zaten var";
        public static string AccessTokenCreated = "yaratıldı";
    }
}
