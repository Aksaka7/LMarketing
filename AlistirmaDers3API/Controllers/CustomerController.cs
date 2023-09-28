using Microsoft.AspNetCore.Mvc;
using AlistirmaDers3API.Model;

namespace AlistirmaDers3API.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("Registration")]

        public IActionResult Registration()
        {
            var oyuncu = new Customer_Registration();

            oyuncu.AdiniAl("Mehmet");
            oyuncu.SoyAdiWrite("ASKER");
            oyuncu.Kullanici_Adi_Yaz("Aksaka7");
            oyuncu.Passport_No_Yaz("TC6535362");
            oyuncu.Ulkeyi_Yaz("Türkiye");
            oyuncu.Birth_OF_Tarihi_Yaz("18/10/1988");
            oyuncu.Para_Birimini_Yaz("TRY");
            oyuncu.User_ID_Number_Yaz(621200021);
            oyuncu.E_Mail_Adresini_Yaz("Aksaka7@gmail.com");
            oyuncu.Telefon_No_Yaz("+35699919587");


            var arac = new Car();

            arac.Markasi = "BMW"; // Burada FArklı bir Classtan Bir Bilgi akışı yaptım :D 



            return Ok(oyuncu.AdiniGoster()+" "+ oyuncu.SoyAdiRead() + "\nKullanıcı Adı : " + 
                oyuncu.Kullanici_Adi_Oku() + "\nPassport No: "+ oyuncu.Pasaport_No_Oku() + "\nÜlke: " + oyuncu.Ulkeyi_Oku()
                + "\nDogum Tarihi: " + oyuncu.Birth_OF_Tarihi_Oku()+ "\nPara Birimi: "+ oyuncu.Para_Birimini_Oku() + "\nCustomer ID: " 
                + oyuncu.User_ID_Number_Oku() + "\nE-Mail Adresi: " + oyuncu.E_Mail_Adresini_Oku()+ "\nTelefon Numarası: " + oyuncu.Telefon_No_Oku()
                 + "\nArabası: " + arac.Markasi );
        }

    }
}
