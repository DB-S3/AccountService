using Common;
using Common.Interfaces;
using Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Register
    {
        readonly ICheck check;
        readonly IAccountChanges AccountChanges;

        public Response CreateAccount(string userName, string password, string mail, DateTime dateOfBirth)
        {
            if (check.CheckIfUserExists(mail) == false && userName.Length > 0 && password.Length > 0 && mail.Length > 0)
            {
                AccountChanges.createAccount(userName, password, mail, dateOfBirth, Guid.NewGuid().ToString());
                return new Response() {succes = true, request="Register"};
            }
            return new Response() { succes = false, request = "Register", code="Missing info" };
        }

        public Register()
        {
            check = FactoryCS.GetChecks();
            AccountChanges = FactoryCS.GetAccountChanges();
        }
    }
}
