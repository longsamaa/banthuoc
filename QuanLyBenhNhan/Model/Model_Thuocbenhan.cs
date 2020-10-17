using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace QuanLyBenhNhan.Model
{
    class Model_Thuocbenhan
    {
        public bool Themthuocbenhan(int idbenhan,int idthuoc, int soluong)
        {
            bool re = false;
            String query = "Insert Into thuocbenhan(idbenhan,idthuoc,soluong) Values ('"+idbenhan+"','"+idthuoc+"','"+soluong+"')";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true; 
            }
            return re; 
        }
        public DataTable Load_soluongthuocbenhan(int idbenhan,int idthuoc)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select soluong From thuocbenhan Where idbenhan = '"+idbenhan+"' And idthuoc = '"+idthuoc+"'";
            re = Connect.Dulieutable(query);
            return re; 
        }
    }
}
