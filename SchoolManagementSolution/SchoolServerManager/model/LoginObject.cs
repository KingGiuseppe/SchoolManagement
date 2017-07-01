﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolServerManagement.model
{
    [Serializable]
    class LoginObject
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginObject(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}