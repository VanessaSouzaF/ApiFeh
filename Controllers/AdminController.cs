using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiFeh.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        [HttpGet]
        [Authorize(Roles = "admin")]
        public string Admin() => "Administrador";
    }
}