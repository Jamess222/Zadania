﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{

    class DBConnection
    { 
        public MySqlConnection cn;
        public void Connect()
        {
            cn = new MySqlConnection("Datasource=127.0.0.1;username=root;password=;database=dbc");
        }
    }
}
