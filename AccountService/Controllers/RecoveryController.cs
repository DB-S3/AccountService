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
    public class RecoveryController : ControllerBase
    {
        [Route("CreateRecovery/{mail}")]
        [HttpGet]
        public Response Register(string mail)
        {
            return new Logic.Recovery().RequestRecoveryCreation(mail);
        }

        [Route("Recover/{recoveryId}/{newPassword}")]
        [HttpGet]
        public Response Register(string recoveryId, string newPassword)
        {
            return new Logic.Recovery().RecoverAccount(recoveryId, newPassword);
        }
    }
}
