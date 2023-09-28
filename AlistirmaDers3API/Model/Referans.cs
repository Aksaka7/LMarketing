namespace AlistirmaDers3API.Model
{
    public class Referans: Customer_Registration
    {

        private double Balance;
        private double Bonus_Balance;
        private int Transaction_ID;
        private string Brand_Name;
        private byte Toplam_Referans_Sayisi;
        private byte Gelen_Referans_Sol;
        private byte Gelen_Referans_Sag;


        public double Player_Balance_Read() {  return Balance; }
        public double Player_Balance_Write(double bakiye){ return Balance = bakiye; }

        public double Bonus_Balance_Read() { return Bonus_Balance; }
        public double Bonus_Balance_write(double bonus) { return Bonus_Balance = bonus; }

        public int Islemlerin_ID_Read() { return Transaction_ID; }
        public int Islemlerin_ID_Write(int id) { return Transaction_ID = id;}

        public string Marka_ID_NameRead() { return Brand_Name; }
        public string Marka_ID_nameWrite(string sube) { return Brand_Name = sube;}

        public byte ReferansSayisi_Read()
        {
            
            return Toplam_Referans_Sayisi;
        } 

        public byte ReferansSayisi_write(byte sayi)
        {
            if(sayi >= 1)
            {
                sayi = 0;
                Toplam_Referans_Sayisi++;
            }
            else
            {
                Toplam_Referans_Sayisi++;
            }
            return Toplam_Referans_Sayisi;
        }

        public byte Incoming_musteri_Left_Read() 
        {
            return Gelen_Referans_Sol;
        }

        public byte Incoming_musteri_Left_Write(byte sol) { return Gelen_Referans_Sol = sol; }

        public byte Incoming_musteri_RightRead()
        {
            return Gelen_Referans_Sag;
        }

        public byte Incoming_musteri_RightWrite(byte sag)
        {
            return Gelen_Referans_Sag = sag;
        }
    }
}
