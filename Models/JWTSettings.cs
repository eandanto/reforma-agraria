﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reforma_agraria.Models
{
    public class JwtSettings
    {
            public string SecretKey { get; set; }
            public string Issuer { get; set; }
            public string Audience { get; set; }
    }
}
