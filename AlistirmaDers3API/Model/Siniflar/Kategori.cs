using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Model.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriName { get; set; }
        public ICollection<Urun> Uruns { get; set; }// Burada Ürün Class ı ile ilişkili yaptık
    }
}
