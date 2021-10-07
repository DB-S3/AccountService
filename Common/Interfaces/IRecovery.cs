using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IRecovery
    {
        void CreateRecovery(string AccountId, string recoveryId, DateTime requestDate);
        bool CheckIfRecoveryIdExists(string recoveryId);
        void RemoveRecoveryId(string recoveryId);
    }
}
