using Microsoft.AspNetCore.Mvc;
using AlistirmaDers3API.Model;

namespace AlistirmaDers3API.Controllers
{
    public class ReferansController : Controller
    {
        [HttpGet]
        [Route("Referans")]
        public IActionResult Referans()
        {
            return Ok("Merhaba Comologgo");
        }
    }
}
