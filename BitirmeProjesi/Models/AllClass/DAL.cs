﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BitirmeProjesi.Models.AllClass
{
    public class DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);
        SqlDataAdapter da = null;
        DataTable dt= null;

        public string GetLogin(Login login)
        {
            da = new SqlDataAdapter("Select * from Users where FirstName = '" + login.FirstName + "' and Password = '" + login.Password + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return "Logged In";
            else
                return "Login Failed";
         
        }
    }
}