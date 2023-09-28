using AlistirmaDers3API.Model;
using Microsoft.AspNetCore.Mvc;

namespace AlistirmaDers3API.Controllers
{
    public class IncomingcustomerController : Controller
    {
        [HttpGet]
        [Route("Gelenmusteri")]

        public IActionResult Gelenmusteri()
        {
            var _customer = new Referans();

            _customer.AdiniAl("Mehmet");
            _customer.SoyAdiWrite("ASKER");
            _customer.Kullanici_Adi_Yaz("Aksaka7");
            _customer.Passport_No_Yaz("TC6535362");
            _customer.Ulkeyi_Yaz("Türkiye");
            _customer.Birth_OF_Tarihi_Yaz("18/10/1988");
            _customer.Para_Birimini_Yaz("TRY");
            _customer.Player_Balance_Write(150.5);
            _customer.Bonus_Balance_write(75.5);
            _customer.Islemlerin_ID_Write(25632656);
            _customer.Marka_ID_nameWrite("Referans");
            _customer.ReferansSayisi_write(2);

            var donustur.



            return Ok(_customer.AdiniGoster() + " " + _customer.SoyAdiRead() + "\nKullanıcı Adı : " +
                _customer.Kullanici_Adi_Oku() + "\nPassport No: " + _customer.Pasaport_No_Oku() + "\nÜlke: " + _customer.Ulkeyi_Oku()
                + "\nDogum Tarihi: " + _customer.Birth_OF_Tarihi_Oku() + "\nPara Birimi: " + _customer.Para_Birimini_Oku() + "\nBakiye: " + _customer.Player_Balance_Read() + 
                 "\nBonus Bakiye: "+ _customer.Bonus_Balance_Read() + "\nİşlem ID: " + _customer.Islemlerin_ID_Read() + "\nİşlem Adı: " + _customer.Marka_ID_NameRead() +
                 "\nMüşteri Referansları: "+ _customer.ReferansSayisi_Read());
        }
    }
}
