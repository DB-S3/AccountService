using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IDataLookUp
    {
        string GetIdByMail(string _mail);
        string GetIdByRecoveryId(string _recoveryId);
    }
}
