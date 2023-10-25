namespace AlistirmaDers3API.Model.Siniflar
{
    public class Faturalar
    {
       public int FaturaId { get; set; }
        public string FaturaSeriNo { get; set; }
        public string FaturaSiraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        public DateTime Saat {  get; set; }
        public string TeslimEden {  get; set; }
        public string TeslimAlan {  get; set; }
        public ICollection<FaturaKalem> Faturakalems { get; set; }// Bir Faturanın Birden fazla Fatura kale
    }
}
