using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constanst
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarValided = "Araç tanımlaması en az 2 karakter içermeli ve günlük kirası 0'dan fazla olmalıdır!";
        public static string CarListed="Arabalar Listelendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renk Listelendi";

        public static string BrandAdded = "Model Eklendi";
        public static string BrandDeleted = "Model Silindi";
        public static string BrandUpdated = "Model Güncellendi";
        public static string BrandListed = "Model Listelendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteri Listelendi";


        public static string Delivered = "Teslim Yapıldı";
        public static string NotDelivered = "Teslim Yapılmadı";
        public static string CarRented = "Araç Kiralandı";
        public static string CarNotRented = "Araç Kiralanmadı";
        public static string RentalListed = "Kiralama Listelendi";

        public static string MaintanceTime = "Sistem Bakımda";
    }
}
