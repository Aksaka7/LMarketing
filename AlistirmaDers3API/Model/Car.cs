namespace AlistirmaDers3API.Model
{
    public class Car
    {

        //Dışarıdan ulasılmaması için Bu nesne özelligini Private yaptık.
        private string Plaka;
        private byte UretimYili;
        private string Color;
        private string Model;
        private string Marka;



        public string PlakayiOku()
        {
            return Plaka;
        }

        public void PlakayiWrite(string plaka)
        {   
            Plaka = plaka;
        }



        public byte UretimYiliOku()
        {
            return UretimYili;
        }

        public byte UretimYiliWrite(byte uretimyili)
        {
            UretimYili = uretimyili;
            return UretimYili;
        }

        public string ColorEngi { get; set; }

        public string Modeli { get; set; }

        public string Markasi { get; set; }
    }
}
