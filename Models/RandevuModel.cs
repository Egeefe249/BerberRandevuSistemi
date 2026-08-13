using System;

namespace BerberRandevuSistemi.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; } = "";
        public string Telefon { get; set; } = "";
        public DateTime RandevuTarihi { get; set; }
        public bool OnaylandiMi { get; set; } = false;
    }
}