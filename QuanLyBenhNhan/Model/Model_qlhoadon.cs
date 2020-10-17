using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBenhNhan.Model
{
    class Model_qlhoadon
    {
        public bool ThemHoaDon(int idbenhan,int tongtien,String ngaythang)
        {
            bool re;
            re = false;
            String query = "Insert into hoadon(idbenhan,tongtien,ngaythanhtoan) Values ('"+idbenhan+"','"+tongtien+"','"+ngaythang+"')";
            if (Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re; 
        }
        public DataTable Loadhoadon(int idbenhan)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * From hoadon Where idbenhan = '" + idbenhan + "'";
            re = Connect.Dulieutable(query);
            return re;
        }
    }
}
