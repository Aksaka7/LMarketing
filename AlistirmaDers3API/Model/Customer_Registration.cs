namespace AlistirmaDers3API.Model
{
    public class Customer_Registration
    {
        public string Name;//
        public string Surname;//
        public string Username;//
        public string Passport_ID_Number;//
        public string Country;//
        private string Date_OF_Birth;//
        private string ParaBirimi;//
        private string Cinsiyeti; //
        private int Customer_ID; //
        private string E_Mail_ID; //
        public string Mobil_Telefon_Number; //

        public string AdiniGoster()
        {
            return Name;
        }

        public void AdiniAl(string name)
        {
            Name = name;
        }

        public string SoyAdiRead()
        {
            return Surname;
        }

        public void SoyAdiWrite(string soyad)
        {
            Surname = soyad;
        }

        public string Kullanici_Adi_Oku()
        {
            return Username;
        }
        public void Kullanici_Adi_Yaz(string user)
        {
            Username = user;
        }

        public string Pasaport_No_Oku()
        {
            return Passport_ID_Number;
        }

        public void Passport_No_Yaz(string passport)
        {
            Passport_ID_Number = passport;
        }

        public string Ulkeyi_Oku()
        {
            return Country;
        }

        public void Ulkeyi_Yaz(string ulke)
        {
            Country = ulke;
        }


        public string Birth_OF_Tarihi_Oku()
        {
            return Date_OF_Birth;
        }

        public void Birth_OF_Tarihi_Yaz(string dogum_tarihi)
        {
            Date_OF_Birth = dogum_tarihi;
        }

        public string Para_Birimini_Oku()
        {
            return ParaBirimi;
        }

        public void Para_Birimini_Yaz(string para)
        {
            ParaBirimi = para;
        }

        public string Erkek_Mi_Kadin_Mİ_Oku()
        {
            return Cinsiyeti;
        }

        public int User_ID_Number_Oku()
        {
            return Customer_ID;
        }

        public void User_ID_Number_Yaz(int id)
        {
            Customer_ID = id;
        }

        public string Telefon_No_Oku()
        {
            return Mobil_Telefon_Number;
        }

        public void Telefon_No_Yaz(string telNo)
        {
            Mobil_Telefon_Number = telNo;
        }

        public string E_Mail_Adresini_Oku()
        {
            return E_Mail_ID;
        }

        public void E_Mail_Adresini_Yaz(string email)
        {
            E_Mail_ID = email;
        }


    }
}
