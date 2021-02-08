namespace Business.Constants
{
    public static class Messages
    {
        public static class SecurityMessages
        {
            public static string UserNotFound { get { return "Kullanıcı bulunamadı."; } }
            public static string PasswordError { get { return "Şifre yanlış."; } }
            public static string SuccessfulLogin { get { return "Sisteme giriş başarılı."; } }
            public static string UserAlreadyExist { get { return "Bu kullanıcı zaten mevcut."; } }
            public static string UserRegistered { get { return "Kullanıcı başarıyla kaydedildi."; } }
            public static string AccessTokenCreated { get { return "AccessToken başarıyla oluşturuldu."; } }
            public static string AuthorizationDenied { get { return "Yetkiniz yok."; } }
        }
        public static class SuccessMessages
        {
            public static string StokInserted { get { return "Stok kartı başarıyla eklendi."; } }
            public static string StokDeleted { get { return "Stok kartı başarıyla silindi."; } }
            public static string StokUpdated { get { return "Stok kartı başarıyla güncellendi."; } }

            public static string StokInsertedToGrup { get { return "Stok başarıyla gruba eklendi."; } }
            public static string StokDeletedFromGrup { get { return "Stok başarıyla gruptan çıkarıldı."; } }
            public static string StokTransferredToGrup { get { return "Stoğun grup bilgisi başarıyla güncellendi."; } }

            public static string StokGrupInserted { get { return "Yeni Stok Grup Kod başarıyla eklendi."; } }
            public static string StokGrupUpdated { get { return "Stok Grup Kod başarıyla güncellendi."; } }
            public static string StokGrupDeleted { get { return "Stok Grup Kod başarıyla silindi."; } }

            public static string StockActivityInserted { get { return "Stok Hareket başarıyla eklendi."; } }
            public static string StockActivityUpdated { get { return "Stok Hareket başarıyla güncellendi."; } }
            public static string StockActivityDeleted { get { return "Stok Hareket başarıyla silindi."; } }

            public static string CariInserted { get { return "Cari başarıyla eklendi."; } }
            public static string CariUpdated { get { return "Cari başarıyla güncellendi."; } }
            public static string CariDeleted { get { return "Cari başarıyla silindi."; } }

            public static string CariInsertedToGrup { get { return "Cari başarıyla gruba eklendi."; } }
            public static string CariDeletedFromGrup { get { return "Cari başarıyla gruptan çıkarıldı."; } }
            public static string CariTransferredToGrup { get { return "Carinin grup bilgisi başarıyla güncellendi."; } }

            public static string CariGrupInserted { get { return "Yeni Cari Grup başarıyla eklendi."; } }
            public static string CariGrupUpdated { get { return "Cari Grup başarıyla güncellendi."; } }
            public static string CariGrupDeleted { get { return "Cari Grup başarıyla silindi."; } }

            public static string CariActivityAdded { get { return "Cari Hareket başarıyla eklendi."; } }
            public static string CariActivityDeleted { get { return "Cari Hareket başarıyla silindi."; } }
            public static string CariActivityUpdated { get { return "Cari Hareket başarıyla güncellendi."; } }

            public static string EvrakInserted { get { return "Evrak başarıyla eklendi."; } }
            public static string EvrakDeleted { get { return "Evrak başarıyla silindi."; } }
            public static string EvrakUpdated { get { return "Evrak başarıyla güncellendi."; } }

            public static string DegerliKagitInserted { get { return "Değerli evrak başarıyla eklendi."; } }
            public static string DegerliKagitDeleted { get { return "Değerli evrak başarıyla silindi."; } }
            public static string DegerliKagitUpdated { get { return "Değerli evrak başarıyla güncellendi."; } }
        }
        public static class ErrorMessages
        {
            #region StokBusinessRules
            public static string StokAlreadyExists { get { return "Stok kartı zaten mevcut."; } }
            public static string StokNotExists { get { return "Stok kartı bulunamadı."; } }
            public static string StokKodNotExists { get { return "Stok Kod bulunamadı."; } }
            public static string StokBarkodNotExists { get { return "Stok Barkod bulunamadı."; } }
            public static string StokAdNotExists { get { return "Stok Ad bulunamadı."; } }
            public static string StokKdvNotExists { get { return "Stok KDV bulunamadı."; } }
            #endregion

            #region StokGrupBusinessRules
            public static string StokGrupAssignmentAlreadyExists { get { return "Stok-Grup ilişiklendirmesi zaten var."; } }
            public static string StokGrupAssignmentNotExists { get { return "Stok-Grup ilişiklendirmesi bulunamadı."; } }
            #endregion

            #region StokGrupKodBusinessRules
            public static string StokGrupAlreadyExists { get { return "StokGrupKod zaten mevcut."; } }
            public static string StokGrupNotExists { get { return "StokGrupKod bulunamadı."; } }
            public static string StokGrupAdNotExists { get { return "StokGrupKod adı bulunamadı."; } }
            public static string StokGrupTurNotExists { get { return "StokGrupKod türü bulunamadı."; } }
            #endregion

            #region StokHareketBusinessRules
            public static string StokAmountNotEnough { get { return "Stok Bakiye yetersiz."; } }
            public static string StokHareketNotExists { get { return "StokHareket bulunamadı."; } }
            #endregion

            #region CariBusinessRules
            public static string CariAlreadyExists { get { return "Cari Kartı Zaten Mevcut."; } }
            public static string CariNotExists { get { return "Cari Kartı Bulunamadı."; } }
            public static string CariKodNotExists { get { return "Cari Kod Bulunamadı."; } }
            public static string CariUnvanNotExists { get { return "Cari Unvan Bulunamadı."; } }
            public static string SahisCariTCNoNotExists { get { return "Şahıs Cari TC No Bulunamadı."; } }
            public static string SirketCariVergiNoNotExists { get { return "Şirket Cari Vergi No Bulunamadı."; } }
            public static string CariVergiDairesiNotExists { get { return "Cari Vergi Dairesi Bulunamadı."; } }
            #endregion

            #region CariGrupBusinessRules
            public static string CariGrupAssignmentAlreadyExists { get { return "Cari-Grup ilişiklendirmesi zaten mevcut."; } }
            public static string CariGrupAssignmentNotExists { get { return "Cari-Grup ilişiklendirmesi bulunamadı."; } }
            #endregion

            #region CariGrupKodBusinessRules
            public static string CariGrupAlreadyExists { get { return "CariGrup zaten mevcut."; } }
            public static string CariGrupNotExists { get { return "CariGrup bulunamadı."; } }
            public static string CariGrupAdNotExists { get { return "CariGrup adı Bulunamadı."; } }
            public static string CariGrupTurNotExists { get { return "CariGrup türü bulunamadı."; } }
            #endregion

            #region CariHareketBusinessRules
            public static string CariActivityAlreadyExists { get { return "StokHareket zaten mevcut."; } }
            public static string CariActivityNotExists { get { return "StokHareket bulunamadı."; } }
            #endregion

            #region EvrakBusinessRules
            public static string EvrakAlreadyExists { get { return "Fatura zaten mevcut."; } }
            public static string EvrakNotExists { get { return "Fatura bulunamadı."; } }
            public static string FaturaNoNotExists { get { return "FaturaNo bulunamadı."; } }
            public static string IrsaliyeNoNotExists { get { return "IrsaliyeNo bulunamadı."; } }
            public static string EvrakDateNotExists { get { return "Evrak Tarihi bulunamadı."; } }
            #endregion

            #region DegerliKagitBusinessRules
            public static string DegerliKagitAlreadyExists { get { return "Değerli evrak zaten mevcut."; } }
            public static string DegerliKagitNotExists { get { return "Değerli evrak bulunamadı."; } }
            public static string DegerliKagitVadeNotExists { get { return "Vadeyi yanlış girdiniz."; } }
            public static string DegerliKagitTutarNotExists { get { return "Tutarı yanlış girdiniz."; } }
            public static string DegerliKagitDateNotExists { get { return "Evrak tarihi bulunamadı."; } }
            public static string DegerliKagitAsilBorcluNotExists { get { return "Asıl borçlu bulunamadı."; } }
            #endregion

            #region
            public static string PersonelActivityNotExists { get { return "Personel Hareket bulunamadı."; } }
            public static string PersonelNotExists { get { return "Personel bulunamadı."; } }
            public static string DepoNotExists { get { return "Depo bulunamadı."; } }
            public static string HesapIdNotExists { get { return "Hesap bilgisi bulunamadı."; } }
            public static string BankaNotExists { get { return "Banka bulunamadı."; } }
            #endregion
        }
    }
}