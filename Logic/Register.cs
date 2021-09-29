using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Register
    {
        public void CreateAccount(string userName, string password, string mail, DateTime dateOfBirth)
        {
            Data.AccountChanges.createAccount(userName, password, mail, dateOfBirth, Guid.NewGuid().ToString());
        }
    }
}
