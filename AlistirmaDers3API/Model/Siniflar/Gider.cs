using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Model.Siniflar
{
    public class Gider
    {
        [Key]
        public int GiderId { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar {  get; set; }
    }
}
