using System.Threading;
using api.Data;
using api.Data.UnitOfWork;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
  [Route("api/[controller]/auth")]
  [ApiController]
  public class ReceptoresController : ControllerBase
  {
    private readonly UnitOfWork _uow;

    public ReceptoresController()
    {
      _uow = new UnitOfWork(new );
    }
    public string Ping() => "Hola";

    [HttpPost]
    public bool Registro(Receptor receptor)
    {

      return true;
    }
  }
}