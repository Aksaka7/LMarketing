using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Model.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }
        //Ürün
        //Cari
        //Personel
        public DateTime Tarih {  get; set; }
        public int adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set;}
    }
}
