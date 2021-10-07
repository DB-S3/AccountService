using Common;
using Common.Interfaces;
using Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Recovery
    {
        readonly ICheck check;
        readonly IAccountChanges accountChanges;
        readonly IRecovery recovery;
        readonly IDataLookUp dataLookUp;

        public Response RequestRecoveryCreation(string _mail) {
            if (check.CheckIfUserExists(_mail))
            {
                string recoveryId = Guid.NewGuid().ToString();
                recovery.CreateRecovery(dataLookUp.GetIdByMail(_mail), recoveryId, DateTime.Now);
                return new Response() { request = "Create Recovery Request", succes = true };
            }
            else {
                return new Response() { request = "Create Recovery Request", succes = false, code="User Not Found" };
            }
        }


        public Response RecoverAccount(string _recoveryId, string _password) {
            if (recovery.CheckIfRecoveryIdExists(_recoveryId)) {
                accountChanges.changePassword(_password, dataLookUp.GetIdByRecoveryId(_recoveryId));
                recovery.RemoveRecoveryId(_recoveryId);
                return new Response() { request = "Recover Account", succes = true };
            }
            return new Response() { request = "Recover Account", succes = false, code="Invalid Recovery Id" };
        }

        public Recovery()
        {
            check = FactoryCS.GetChecks();
            accountChanges = FactoryCS.GetAccountChanges();
            recovery = FactoryCS.GetRecovery();
            dataLookUp = FactoryCS.GetDataLookUp();
        }
    }
}
