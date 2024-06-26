﻿using MySql.Data.MySqlClient;

namespace BlazorManagement.Data
{
    public class DBMySQL
    {
        private static string Host = "localhost";
        private static string Username = "root";
        private static string Password = "";
        private static int Port = 3306;
        private static string Database = "company";

        public static MySqlConnection GetMySqlConnection()
        {
            string connString = String.Format($"Server={Host};Database={Database};User={Username};Password={Password};Port={Port}");
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}