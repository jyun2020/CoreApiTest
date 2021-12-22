using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Authentication
{
    public class JwtOption
    {
        public string iss { get; set; }
        public string Secret { get; set; }
    }
}
