using System.ComponentModel.DataAnnotations;

namespace ProjeCorePersonel.Models
{
    public class Birim
    {
        [Key]
        public int BirimId { get; set; }
        public string BirimAd { get; set; }
        public IList<Personel> Personels { get; set; }
    }
}
