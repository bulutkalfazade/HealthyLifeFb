﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.AllClass
{
    public class BAL
    {
        public string GetLogin(Login login)
        {
            DAL dal = new DAL();
            string response = dal.GetLogin(login);
            return response;
        }
    }
}