using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common
{
    public class Recovery
    {
        public Account account { get; set; }
        public string accountId { get; set; }
        [Key]
        public string recoveryId { get; set; }
        public DateTime requestDate { get; set; }

    }
}
