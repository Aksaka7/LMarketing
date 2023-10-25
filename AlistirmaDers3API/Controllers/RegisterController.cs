using AlistirmaDers3API.Context;
using AlistirmaDers3API.Model.EntityKayitExample;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlistirmaDers3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly MarketingDBContext dbContect;

        public RegisterController(MarketingDBContext dbContext)
        {
            this.dbContect = dbContext;
        }


        [HttpPost]
        [Route("Registration")]

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

    }
}
