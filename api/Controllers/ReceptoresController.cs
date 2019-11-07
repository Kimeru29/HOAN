using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]/auth")]
    [ApiController]
    public class ReceptoresController : ControllerBase
    {
        public string Ping() => "Hola";
    }
}