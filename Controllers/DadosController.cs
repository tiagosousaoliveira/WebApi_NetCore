using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AnyFit.ViewModel;


namespace AnyFit.Controllers 
{

  [Route ("api/[controller]")]
  [ApiController]
  public class DadosController : ControllerBase
  {
    [HttpGet]
    public ActionResult Version()
    {
      var versao = "Versão 1.0";
      return Ok(new ResponseViewModel {Data = versao});

    }

  }
}