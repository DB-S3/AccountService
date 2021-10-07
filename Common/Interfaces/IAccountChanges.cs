using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IAccountChanges
    {
       void createAccount(string userName, string password, string mail, DateTime dateOfBirth, string id);

        void changePassword(string password, string id);

    }
}
