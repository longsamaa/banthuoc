using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanLyBenhNhan.Model
{
    class Model_qlbenhan
    {
        public bool Them_BenhAn(int idbenhnhan,byte[] image,String trieuchung)
        {
            bool re = false;
            MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=doanpttkpm");
            MySqlCommand command;
            String query = "Insert Into benhan(idbenhnhan,image,trieuchung) Values (@idbenhnhan,@image,@trieuchung)";
            databaseConnection.Open();
            command = new MySqlCommand(query,databaseConnection);

            command.Parameters.Add("@idbenhnhan", MySqlDbType.Int32, 10);
            command.Parameters.Add("@image", MySqlDbType.Blob);
            command.Parameters.Add("@trieuchung", MySqlDbType.VarChar, 200);

            command.Parameters["@idbenhnhan"].Value = idbenhnhan;
            command.Parameters["@image"].Value = image;
            command.Parameters["@trieuchung"].Value = trieuchung;
            if(command.ExecuteNonQuery() > 0)
            {
                re = true;
            }

            return re;
        }
        public DataTable Load_BenhAnIDBenhAn(int idbenhan)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * From benhan Where id = '"+idbenhan+"'";
            re = Connect.Dulieutable(query);
            return re;
        }
        public DataTable Load_idbenhan()
        {
            DataTable re;
            re = new DataTable();
            String query = "Select id From benhan";
            re = Connect.Dulieutable(query);
            return re; 
        }
        public DataTable Load_BenhanIdbenhnhan(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable(); 
            String query = "Select id From benhan Where idbenhnhan = '"+idbenhnhan+"'";
            re = Connect.Dulieutable(query);
            return re; 
        }
        public DataTable Load_hinhanhIdbenhnhan(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select image From benhan Where idbenhnhan = '" + idbenhnhan + "'";
            re = Connect.Dulieutable(query);
            return re; 
        }
        public DataTable Load_TrieuchungIdbenhan(int idbenhan)
        {
            DataTable re;
            re = new DataTable(); 
            String query = "Select trieuchung From benhan Where id = '"+idbenhan+"'";
            re = Connect.Dulieutable(query);
            return re; 
        }
        public bool Xoa_Benhan(int idbenhan)
        {
            bool re;
            re = false;
            String query = "Delete From benhan Where id = '" + idbenhan+ "'";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true; 
            }
            return re; 
        }
    }
}
