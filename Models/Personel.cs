using System.ComponentModel.DataAnnotations;

namespace ProjeCorePersonel.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string Sehir { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }
    }
}
