using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Response
    {
        public dynamic returnValue { get; set; }
        public string code { get; set; }
        public string request { get; set; }
        public bool succes { get; set; }

    }
}
