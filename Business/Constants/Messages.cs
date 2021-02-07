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

            public static string StokAddedToGrup { get { return "Stok başarıyla gruba eklendi."; } }
            public static string StokDeletedFromGrup { get { return "Stok başarıyla gruptan çıkarıldı."; } }
            public static string StokTransferredToGrup { get { return "Stoğun grup bilgisi başarıyla güncellendi."; } }

            public static string StokGrupKodAdded { get { return "Yeni Stok Grup Kod başarıyla eklendi."; } }
            public static string StokGrupKodUpdated { get { return "Stok Grup Kod başarıyla güncellendi."; } }
            public static string StokGrupKodDeleted { get { return "Stok Grup Kod başarıyla silindi."; } }

            public static string StockActivityAdded { get { return "Stok Hareket başarıyla eklendi."; } }
            public static string StockActivityUpdated { get { return "Stok Hareket başarıyla güncellendi."; } }
            public static string StockActivityDeleted { get { return "Stok Hareket başarıyla silindi."; } }

            public static string CariInserted { get { return "Cari başarıyla eklendi."; } }
            public static string CariUpdated { get { return "Cari başarıyla güncellendi."; } }
            public static string CariDeleted { get { return "Cari başarıyla silindi."; } }

            public static string SirketCariInserted { get { return "Şirket Cari başarıyla eklendi."; } }
            public static string SirketCariDeleted { get { return "Şirket Cari başarıyla silindi."; } }
            public static string SirketCariUpdated { get { return "Şirket Cari başarıyla güncellendi."; } }

            public static string SahisCariInserted { get { return "Şahıs Cari başarıyla eklendi."; } }
            public static string SahisCariDeleted { get { return "Şahıs Cari başarıyla silindi."; } }
            public static string SahisCariUpdated { get { return "Şahıs Cari başarıyla güncellendi."; } }

            public static string CariAddedToGrup { get { return "Cari başarıyla gruba eklendi."; } }
            public static string CariDeletedFromGrup { get { return "Cari başarıyla gruptan çıkarıldı."; } }
            public static string CariTransferredToGrup { get { return "Carinin grup bilgisi başarıyla güncellendi."; } }

            public static string CariGrupKodAdded { get { return "Yeni Cari Grup Kod başarıyla eklendi."; } }
            public static string CariGrupKodUpdated { get { return "Cari Grup Kod başarıyla güncellendi."; } }
            public static string CariGrupKodDeleted { get { return "Cari Grup Kod başarıyla silindi."; } }

            public static string CariActivityAdded { get { return "Stok Hareket başarıyla eklendi."; } }
            public static string CariActivityDeleted { get { return "Stok Hareket başarıyla silindi."; } }
            public static string CariActivityUpdated { get { return "Stok Hareket başarıyla güncellendi."; } }

            public static string FaturaInserted { get { return "Fatura başarıyla eklendi."; } }
            public static string FaturaDeleted { get { return "Fatura başarıyla silindi."; } }
            public static string FaturaUpdated { get { return "Fatura başarıyla güncellendi."; } }

            public static string IrsaliyeInserted { get { return "Irsaliye başarıyla eklendi."; } }
            public static string IrsaliyeDeleted { get { return "Irsaliye başarıyla silindi."; } }
            public static string IrsaliyeUpdated { get { return "Irsaliye başarıyla güncellendi."; } }
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
            public static string StokGrupAssignmentNotExists { get { return "Stok-Grup ilişiklendirmesi bulunamadı."; } }
            public static string StokGrupAssignmentAlreadyExists { get { return "Stok-Grup ilişiklendirmesi zaten var."; } }
            #endregion

            #region StokGrupKodBusinessRules
            public static string StokGrupKodAlreadyExists { get { return "StokGrupKod zaten mevcut."; } }
            public static string StokGrupKodNotExists { get { return "StokGrupKod bulunamadı."; } }
            public static string StokGrupKodAdNotExists { get { return "StokGrupKod adı bulunamadı."; } }
            public static string StokGrupKodTurNotExists { get { return "StokGrupKod türü bulunamadı."; } }
            #endregion

            #region StokHareketBusinessRules
            public static string StokHareketNotExists { get { return "StokHareket bulunamadı."; } }
            public static string StokAmountNotEnough { get { return "Stok Bakiye yetersiz."; } }
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
            public static string CariGrupAssignmentNotExists { get { return "Cari-Grup ilişiklendirmesi bulunamadı."; } }
            public static string CariGrupAssignmentAlreadyExists { get { return "Cari-Grup ilişiklendirmesi zaten mevcut."; } }
            #endregion

            #region CariGrupKodBusinessRules
            public static string CariGrupKodAlreadyExists { get { return "CariGrupKod zaten mevcut."; } }
            public static string CariGrupKodNotExists { get { return "CariGrupKod bulunamadı."; } }
            public static string CariGrupKodAdNotExists { get { return "CariGrupKod Adı Bulunamadı."; } }
            public static string CariGrupKodTurNotExists { get { return "CariGrupKod türü bulunamadı."; } }
            #endregion

            #region CariHareketBusinessRules
            public static string CariActivityNotExists { get { return "StokHareket bulunamadı."; } }
            public static string CariActivityAlreadyExists { get { return "StokHareket zaten mevcut."; } }
            #endregion

            #region EvrakBusinessRules
            public static string FaturaNotExists { get { return "Fatura bulunamadı."; } }
            public static string FaturaNoNotExists { get { return "FaturaNo bulunamadı."; } }
            public static string FaturaNoAlreadyExists { get { return "Fatura zaten mevcut."; } }
            public static string IrsaliyeNotExists { get { return "Irsaliye bulunamadı."; } }
            public static string IrsaliyeNoNotExists { get { return "IrsaliyeNo bulunamadı."; } }
            public static string IrsaliyeNoAlreadyExists { get { return "Irsaliye zaten mevcut."; } }
            public static string EvrakDateNotExists { get { return "Evrak Tarihi bulunamadı."; } }
            #endregion

            #region
            public static string PersonelActivityNotExists { get { return "Personel Hareket bulunamadı."; } }
            public static string PersonelNotExists { get { return "Personel bulunamadı."; } }
            public static string DepoNotExists { get { return "Depo bulunamadı."; } }

            public static string DegerliKagitNotExists { get; internal set; }
            public static string TutarIsInvalid { get; internal set; }
            public static string VadeIsInvalid { get; internal set; }
            public static string BankaNotExists { get; internal set; }
            #endregion
        }
    }
}