using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        [Route("login/{userName}/{password}")]
        [HttpGet]
        public Response login(string userName, string password)
        {
            return new Logic.Login().login(userName, password);
        }
    }
}
