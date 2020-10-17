using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanLyBenhNhan.Model
{
    class Model_qlbn
    {
        public DataTable loadTaikhoan(String taikhoan, String matkhau) //Load tat ca cac tai khoan voi tai khoan va mat khau
        {
            DataTable re;
            re = new DataTable();
            string query = "Select * from taikhoan Where taikhoan='" + taikhoan + "' and matkhau='" + matkhau + "' ";
            re = Connect.Dulieutable(query);
            return re;
        }
        public bool ThemBenhNhan(String hovaten,String gioitinh,String diachi,String ngaykham)
        {
            bool re = false;
            String query = "Insert into benhnhan(hoten,gioitinh,diachi,ngaykham) Values ('"+  hovaten +"','"+ gioitinh +"','"+ diachi +"','"+ ngaykham +"')";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable LoadBenhNhan()
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * from benhnhan";
            re = Connect.Dulieutable(query);
            return re;
        }
        public bool XoaBenhNhan(int id)
        {
            bool re = false;
            String query = "Delete From benhnhan Where id = '" + id + "'";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re;
        }
        public bool CapNhatBenhNhan(int id,String hoten,String gioitinh,String diachi,String ngaykham)
        {
            bool re = false;
            String query = "Update benhnhan Set hoten = '" + hoten + "',gioitinh = '"+ gioitinh + "',diachi = '" + diachi + "',ngaykham = '" + ngaykham + "' Where id = '" + id + "' ";
            if (Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable TimKiemBenhNhan(String tmp,int id,int dem)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * from benhnhan Where hoten Like '%" + tmp + "%'";
            if (dem == 0)
            {
                query = "Select * from benhnhan Where hoten Like '%" + tmp + "%'";
            }
            if (dem == 1)
            {
                query = "Select * from benhnhan Where diachi Like '%" + tmp + "%'";
            }
            if (dem == 2)
            {
                query = "Select * from benhnhan Where ngaykham Like '%" + tmp + "%'";
            }
            if(dem == 3)
            {
                query = "Select * from benhnhan Where id Like '%" + id + "%'";
            }
            re = Connect.Dulieutable(query);
            return re;
        }
    }
}
