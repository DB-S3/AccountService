using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface ICheck
    {
        public bool CheckIfUserExists(string mail);
        public int CheckIfPasswordIsCorrect(string mail, string password);
     
    }
}
