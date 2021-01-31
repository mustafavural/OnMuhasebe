namespace Business.Constants
{
    public static class Messages
    {
        public static string StokInserted = "Stok kartı başarıyla eklendi.";
        public static string StokDeleted = "Stok kartı başarıyla silindi.";
        public static string StokUpdated = "Stok başarıyla güncellendi.";

        public static string StokAddedToGrup = "Stok başarıyla gruba eklendi.";
        public static string StokDeletedFromGrup = "Stok başarıyla gruptan çıkarıldı.";
        public static string StokTransferredGrup = "Stoğun grup bilgisi başarıyla güncellendi.";

        public static string StokGrupKodAdded = "Yeni Stok Grup Kod başarıyla eklendi.";
        public static string StokGrupKodUpdated = "Stok Grup Kod başarıyla güncellendi.";
        public static string StokGrupKodDeleted = "Stok Grup Kod başarıyla silindi.";

        public static string StockActivityAdded = "Stok Hareket başarıyla eklendi.";
        public static string StockActivityUpdated = "Stok Hareket başarıyla güncellendi.";
        public static string StockActivityDeleted = "Stok Hareket başarıyla silindi.";

        public static string CariInserted = "Cari başarıyla eklendi.";
        public static string CariUpdated = "Cari baarıyla güncellendi.";
        public static string CariDeleted = "Cari başarıyla silindi.";

        public static string SirketCariInserted = "Şirket Cari başarıyla eklendi.";
        public static string SirketCariDeleted = "Şirket Cari başarıyla silindi.";
        public static string SirketCariUpdated = "Şirket Cari başarıyla güncellendi.";

        public static string SahisCariInserted = "Şahıs Cari başarıyla eklendi.";
        public static string SahisCariDeleted = "Şahıs Cari başarıyla silindi.";
        public static string SahisCariUpdated = "Şahıs Cari başarıyla güncellendi.";

        public static string CariAddedToGrup = "Cari başarıyla gruba eklendi.";
        public static string CariDeletedFromGrup = "Cari başarıyla gruptan çıkarıldı.";
        public static string CariTransferredGrup = "Carinin grup bilgisi başarıyla güncellendi.";

        public static string CariGrupKodAdded = "Yeni Cari Grup Kod başarıyla eklendi.";
        public static string CariGrupKodUpdated = "Cari Grup Kod başarıyla güncellendi.";
        public static string CariGrupKodDeleted = "Cari Grup Kod başarıyla silindi.";

        public static string CariActivityAdded = "Stok Hareket başarıyla eklendi.";
        public static string CariActivityDeleted = "Stok Hareket başarıyla silindi.";
        public static string CariActivityUpdated = "Stok Hareket başarıyla güncellendi.";

        #region StokBusinessRules
        public static string StokAlreadyExists = "Stok kartı zaten mevcut.";
        public static string StokIdNotExists = "Stok Id bulunamadı.";
        public static string StokKodNotExists = "Stok Kod bulunamadı.";
        public static string StokBarkodNotExists = "Stok Barkod bulunamadı.";
        public static string StokAdNotExists = "Stok Ad bulunamadı.";
        public static string StokKdvNotExists = "Stok KDV bulunamadı.";
        public static string StokGrupKodIdNotExists = "Stok GrupKodId bulunamadı.";
        public static string StokGrupKodAdNotExists = "Stok GrupKodAd bulunamadı.";
        #endregion

        #region Secure
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre yanlış";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExist = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "AccessToken başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        #endregion

        #region CariBusinessRules
        public static string CariAlreadyExists = "Cari Kartı Zaten Mevcut.";
        public static string CariIdNotExists = "Cari Id Bulunamadı.";
        public static string CariKodNotExists = "Cari Kod Bulunamadı.";
        public static string CariUnvanNotExists = "Cari Unvan Bulunamadı.";
        public static string SahisCariTCNoNotExists = "Şahıs Cari TC No Bulunamadı.";
        public static string SirketCariVergiNoNotExists = "Şirket Cari Vergi No Bulunamadı.";
        public static string CariGrupKodAdNotExists = "CariGrupKod Adı Bulunamadı.";
        public static string CariVergiDairesiNotExists = "Cari Vergi Dairesi Bulunamadı.";
        #endregion
    }
}