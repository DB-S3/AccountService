using Common;
using Common.Interfaces;
using Factory;
using System;

namespace Logic
{
    public class Login
    {
        readonly ICheck check;
        readonly IDataLookUp dataLookUp;

        public Response login(string mail, string password) {
            if (check.CheckIfUserExists(mail) == true && mail.Length > 0 && password.Length > 0) {
                if (check.CheckIfPasswordIsCorrect(mail, password) == 1)
                {
                    return new Response() { returnValue = dataLookUp.GetIdByMail(mail), request = "Login", succes = true };
                }
                return new Response() { request = "Login", succes = false, code = "PasswordIncorrect" };
            }
            return new Response() { request = "Login", succes = false, code="User Not Found" };
        }

        public Login() {
            check = FactoryCS.GetChecks();
            dataLookUp = FactoryCS.GetDataLookUp();
        }
    }
}
