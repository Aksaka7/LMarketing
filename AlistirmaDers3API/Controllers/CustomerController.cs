using Microsoft.AspNetCore.Mvc;
using AlistirmaDers3API.Model;
using AlistirmaDers3API.Model.EntityKayitExample;
using Microsoft.EntityFrameworkCore;
using AlistirmaDers3API.Context;
using Microsoft.AspNetCore.Authorization;

namespace AlistirmaDers3API.Controllers
{
    public class CustomerController : Controller
    {
        private readonly MarketingDBContext dbContect;

        public CustomerController(MarketingDBContext dbContext)
        {
            this.dbContect = dbContext;
        }


        [HttpPost]
        [Route("KullanıcıOluşturma")]

        public IActionResult RegisterUser([FromBody] RegisterCreateUserModel model)
        {
            if (model == null)
            {
                return BadRequest("Bu model Boş bırakılamaz");
            }

            if (string.IsNullOrEmpty(model.Email) && string.IsNullOrEmpty(model.Password))
            {
                return BadRequest("Email ve Parola Boş bırakılamaz");
            }

            dbContect.Registers.Add(new Context.Domain.Register { Name = model.Name, Surname = model.Surname, Email = model.Email, Password = model.Password, Id = Guid.NewGuid() });

            var result = dbContect.SaveChanges();

            if (result < 0)
            {
                return BadRequest("Kullanıcı oluşmadı.");
            }
            else
            {
                return Ok("Üye oluştu");
            }
        }

        [Authorize]
        [HttpGet]
        [Route("ExampleAuthorize")]
        public IActionResult ExampleAuthorize1(string name)
        {
            string result;

            if (name.StartsWith("m"))
            {
                result = "İsminiz Küçük m harfi ile baslıyor";
            }
            else if (name.StartsWith("M"))
            {
                result = "İsminiz Küçük M harfi ile baslıyor";
            }
            else if (name.StartsWith("S"))
            {
                result = "İsminiz H harfi ile baslıyor";
            }
            else
            {
                result = "İsminiz m harfi ile baslamıyor.";
            }

            return Ok(result);
        }

    }
}
