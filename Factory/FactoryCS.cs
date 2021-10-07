using Common.Interfaces;
using System;

namespace Factory
{
    public class FactoryCS
    {
        public static ICheck GetChecks() {
            return new Data.Check();
        }

        public static IAccountChanges GetAccountChanges()
        {
            return new Data.AccountChanges();
        }

        public static IRecovery GetRecovery()
        {
            return new Data.Recovery();
        }
        public static IDataLookUp GetDataLookUp()
        {
            return new Data.DataLookUp();
        }
    }
}
