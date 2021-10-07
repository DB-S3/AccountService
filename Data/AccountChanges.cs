using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class AccountChanges : IAccountChanges
    {
        public void createAccount(string userName, string password, string mail, DateTime dateOfBirth, string id) {
            using (Database db = new Database()) {
                db.Account.Add(new Common.Account() { userName = userName, id = id, dateOfBirth = dateOfBirth, mail = mail, password = password });
                db.SaveChanges();
            }
        }

        public void changePassword(string password, string id)
        {
            using (Database db = new Database())
            {
                db.Account.Where(x => x.id == id).FirstOrDefault().password = password;
                db.SaveChanges();
            }
        }
    }
}
