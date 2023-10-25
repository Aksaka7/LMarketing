using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Model.Siniflar
{
    public class Urun
    {
        [Key]
        public int Urunid { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal BuyPrize { get; set;}
        public decimal SellPrize { get; set;}
        public bool Durum { get; set; }
        public string UrunImg { get; set; }
        public Kategori Kategori { get; set; }//Kategori Class'ı ile ilişkili yaptık
    }
}
