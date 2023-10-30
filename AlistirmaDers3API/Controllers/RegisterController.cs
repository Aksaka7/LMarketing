using AlistirmaDers3API.Context;
using AlistirmaDers3API.Model.EntityKayitExample;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AlistirmaDers3API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly MarketingDBContext dbContext;

        public RegisterController(IConfiguration configuration, MarketingDBContext dbContext)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
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


        [HttpPost]
        [Route("Create")]

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

            dbContext.Registers.Add(new Context.Domain.Register { Name = model.Name, Username = model.Username, Surname = model.Surname, Email = model.Email, Password = model.Password, Id = Guid.NewGuid() });

            var result = dbContext.SaveChanges();

            if (result < 0)
            {
                return BadRequest("Kullanıcı oluşmadı.");
            }
            else
            {
                return Ok("Üye oluştu");
            }
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult LoginUser([FromBody] LoginUserModel model)
        {
            if (string.IsNullOrEmpty(model.Email) && string.IsNullOrEmpty(model.Password))
            {
                return BadRequest("Email ve Password cannot be Empty");
            }
            var response = new UserModel();

            var findUser = dbContext.Registers.FirstOrDefault(p => p.Email == model.Email && p.Password == model.Password);

            if (findUser == null)
            {
                return NotFound("Girilen bilgiler Yanlış");
            }

            var expirationInMinutes = TimeSpan.FromMinutes(10);
            var expireMinute = DateTime.Now.AddMinutes(expirationInMinutes.Minutes);

            var claims = new List<Claim> //Burda Bir Ekrana login işlemi sonrası gorune bilgi ayarlarını yapıyoruz
            {//Şİfreli olan bilgilerde olması gereken detaylar gorunmesini saglıyoruz. 
                new Claim(JwtRegisteredClaimNames.Sub, configuration["JwtSecurityToken:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat,EpochTime.GetIntDate(DateTime.Now).ToString(), ClaimValueTypes.Integer64),
                new Claim(JwtRegisteredClaimNames.Exp,EpochTime.GetIntDate(expireMinute).ToString(), ClaimValueTypes.Integer64),
                new Claim(JwtRegisteredClaimNames.Iss, configuration["JwtSecurityToken:Issuer"]),
                new Claim(JwtRegisteredClaimNames.Aud, configuration["JwtSecurityToken:Issuer"]),
                new Claim("Name",findUser.Name),
                new Claim("Surname",findUser.Surname),
                new Claim("Email", findUser.Email),
                new Claim("UserId", findUser.Id.ToString())
            };

          
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityToken:Key"]));
            var singIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Token oluşturuyoruz ki bilgilerimiz şifreli iletilsin
            var token = new JwtSecurityToken(
                issuer: configuration["JwtSecurityToken:Issuer"],
                audience: configuration["JwtSecurityToken:Audience"],
                claims: claims,
                expires: expireMinute,
                signingCredentials: singIn);

            var tokenHandler = new JwtSecurityTokenHandler();

            response.TokenExpireDate = expireMinute;
            response.Authenticate = true;
            response.Token = tokenHandler.WriteToken(token);

            return Ok(JsonConvert.SerializeObject(response));

        }


    }
}
