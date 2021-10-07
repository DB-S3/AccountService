using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class DataLookUp : IDataLookUp
    {
        public string GetIdByMail(string _mail) {
            using (Database db = new Database())
            {
                return db.Account.Where(x => x.mail == _mail).FirstOrDefault().id;
            }
        }

        public string GetIdByRecoveryId(string _recoveryId)
        {
            using (Database db = new Database())
            {
                return db.Recoveries.Where(x => x.recoveryId == _recoveryId).FirstOrDefault().accountId;
            }
        }
    }
}
