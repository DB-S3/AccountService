using System;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class Account
    {
        [Key]
        public string id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public Recovery recovery { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}
