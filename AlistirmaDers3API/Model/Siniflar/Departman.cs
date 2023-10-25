using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Model.Siniflar
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        public string DepartmanAd {  get; set; }
    }
}
