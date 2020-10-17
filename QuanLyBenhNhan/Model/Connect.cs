using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

//Class model

namespace QuanLyBenhNhan.Model
{
    class Connect
     {
        public static MySqlConnection databaseConnection;
        public static DataTable tb;
        public static MySqlDataAdapter adapter;
        public static MySqlCommand mysqlcommand;
        public static void Openconnect() // Ket noi voi CSDL
        {
            if(databaseConnection == null)
            {
                string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=doanpttkpm";
                databaseConnection = new MySqlConnection(MySQLConnectionString);
            }
           if(databaseConnection.State == ConnectionState.Closed)
            {
                databaseConnection.Open();
            }
        }
        public static void Closeconnect() // Dong CSDL
        {
            if(databaseConnection != null && databaseConnection.State == ConnectionState.Open)
            {
                databaseConnection.Close();
            }
        }
        public static DataTable Dulieutable(string sql) //Truy van va dua ve bang  Table
        {
            Openconnect();
            tb = new DataTable();
            adapter = new MySqlDataAdapter(sql, databaseConnection);
            adapter.Fill(tb);
            return tb;
            Closeconnect();
        }
        public static int ExeCuteNonquery(string sql)
        {
            int re = 0;
            try
            {
                Openconnect();
                mysqlcommand = new MySqlCommand(sql, databaseConnection);
                re = mysqlcommand.ExecuteNonQuery();
                Closeconnect();
                
            }catch
            {

            }
            return re;
        }
    }
}
