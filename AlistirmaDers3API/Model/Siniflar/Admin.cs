using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Model.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Sifre {  get; set; }
        public string Yetki {  get; set; }
    }
}
