using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnyFit.Business;
using AnyFit.Models;
using AnyFit.ViewModel;


namespace AnyFit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private UserBusiness business;

      [HttpPost]
      public ActionResult Create([FromBody] User vm)
      {
        try{
          this.business = new UserBusiness();
          var dados = this.business.Register(vm);
          return Ok(new ResponseViewModel{Data = dados});
        } catch(Exception ex) {
          return StatusCode(500, new ResponseViewModel { ErrorMessage = ex.Message });
        }
      }
    }
}