using Microsoft.AspNetCore.Mvc;
using AlistirmaDers3API.Model;

namespace AlistirmaDers3API.Controllers
{
    public class CarApiController : Controller
    {
        [HttpGet]
        [Route("Car")]
        public IActionResult Car()
        {
            var araba = new Car();
            araba.UretimYiliWrite(165);
            araba.PlakayiWrite("ACE653");
            araba.ColorEngi = "Kırmızı";
            araba.Modeli = "Sport";
            araba.Markasi = "Mazda";

            // araba.Marka = "Toyota";
            // araba.Plaka = "sad568";
            //return Ok(araba.Plaka + "," + araba.Marka);


            return Ok(" Aracın Plakası: "+ araba.PlakayiOku() + " \n Aracın üretim Yılı: " + araba.UretimYiliOku() + "" +
                " \n Aracın Rengi: "+ araba.ColorEngi + " \n Arac modeli: " + araba.Modeli + "\n Arabanın Modeli: "+ araba.Markasi );


        }
    }
}
