using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Model.Siniflar
{
    public class Cari
    {
        [Key]
        public int CariId { get; set; }
        public string CariName { get; set;}
        public string CariSurname { get; set; }
        public string CariCity { get; set; }
        public string CariMail { get; set; }
    }
}
