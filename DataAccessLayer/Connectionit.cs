﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connectionit
    {
        public static SqlConnection conn=new SqlConnection(@"Data Source=DESKTOP-6JPMHUC\SQLSERVERFIRST;Initial Catalog=DbPersonList;Integrated Security=True");
    }
}
