﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeroHunger.DTO
{
    public class LoginDTO
    {
        public int U_ID { get; set; }
        public string NAME { get; set; }
        public string PASS { get; set; }

        public string TIN_CERTIFICATE { get; set; }
    }
}