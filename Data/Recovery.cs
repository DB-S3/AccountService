using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class Recovery : IRecovery
    {
        public void CreateRecovery(string AccountId, string recoveryId, DateTime requestDate) {
            using (Database db = new Database())
            {
                db.Recoveries.Add(new Common.Recovery() { account = db.Account.Where(x => x.id == AccountId).FirstOrDefault(), recoveryId = recoveryId, requestDate = requestDate });
                db.SaveChanges();
            }
        }

        public bool CheckIfRecoveryIdExists(string recoveryId)
        {
            using (Database db = new Database())
            {
                if (db.Recoveries.Where(x => x.recoveryId == recoveryId).Count() == 1)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public void RemoveRecoveryId(string recoveryId)
        {
            using (Database db = new Database())
            {
                db.Recoveries.Remove(db.Recoveries.Where(x => x.recoveryId == recoveryId).FirstOrDefault());
            }
        }
    }
}
