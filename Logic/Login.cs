using System;

namespace Logic
{
    public class Login
    {
        public string login(string userName, string password) {
            if (new Data.Check().CheckIfUserExists(userName) == true && userName.Length > 0 && password.Length > 0) {
                return new Data.Check().CheckIfPasswordIsCorrect(userName, password);
            }
            return "invalid";
        }
    }
}
