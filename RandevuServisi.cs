using BerberRandevuSistemi.Models;

namespace BerberRandevuSistemi.Services
{
    public class RandevuServisi
    {
        // Sistemdeki tüm berberlerin listesi (İleride veritabanına bağlanacak)
        public List<BerberKullanici> Berberler { get; set; } = new()
        {
            new BerberKullanici { Id = 1, KullaniciAdi = "berberahmet", Sifre = "1234", DukkanAdi = "Ahmet Usta Kuaför" },
            new BerberKullanici { Id = 2, KullaniciAdi = "mehmet", Sifre = "abcd", DukkanAdi = "Mehmet Makas" }
        };

        // Şu an sisteme giriş yapmış olan aktif berber (Yönetim panelindeyken bunu kullanacağız)
        public BerberKullanici? AktifBerber { get; set; }
    }
}