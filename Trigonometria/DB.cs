﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trigonometria
{
    public class DB
    {
        private MySqlConnection mySqlKapcsolat;
        public MySqlConnection MysqlKapcsolat
        {
            get { return mySqlKapcsolat; }
            set { mySqlKapcsolat = value; }
        }
        
        private string server;
        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        private string database;
        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        private string uid;
        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public DB(string server, string database, string uid)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;

            string kapcsolat = $"server={server};database={database};uid={uid};";
            mySqlKapcsolat = new MySqlConnection(kapcsolat);
        }
    }
}
