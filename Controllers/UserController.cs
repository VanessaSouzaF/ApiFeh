using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiFeh.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        [Authorize(Roles = "usuario, admin")]
        public string Usuário() => "Usuário";
    }
}