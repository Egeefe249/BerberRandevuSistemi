namespace BerberRandevuSistemi.Models
{
    public class BerberKullanici
    {
        public int Id { get; set; }
        public string DukkanAdi { get; set; } = "";
        public string KullaniciAdi { get; set; } = "";
        public string Sifre { get; set; } = "";
        public string Telefon { get; set; } = ""; // <-- Yeni eklediğimiz alan

        public List<string> AktifBosSaatler { get; set; } = new() { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00" };
        public List<Randevu> RandevuListesi { get; set; } = new();
    }
}