using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class Check
    {
        public bool CheckIfUserExists(string mail) {
            using (Database db = new Database())
            {
                if (db.Account.Where(x => x.mail == mail).Count() == 1)
                {
                    return true;
                }
                else {
                    return false;
                }

            }
        }

        public string CheckIfPasswordIsCorrect(string mail, string password)
        {
            using (Database db = new Database())
            {
                if (db.Account.Where(x => x.mail == mail && x.password == password).Count() == 1)
                {
                    return db.Account.Where(x => x.mail == mail && x.password == password).FirstOrDefault().id;
                }
                else
                {
                    return "invalid";
                }
            }
        }
    }
}
