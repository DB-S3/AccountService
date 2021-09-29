using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class registerController : ControllerBase
    {
        // GET: api/<ValuesController>
        [Route("register/{userName}/{password}/{mail}")]
        [HttpGet]
        public string Register(string userName, string password, string mail)
        {
            new Logic.Register().CreateAccount(userName, password, mail, DateTime.Now);
            return "succes";
        }
    }
}
