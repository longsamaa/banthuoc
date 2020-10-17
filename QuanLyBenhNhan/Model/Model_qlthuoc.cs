using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyBenhNhan.Model
{
    class Model_qlthuoc
    {
        public DataTable loadLoaiThuoc()
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * From loaithuoc";
            re = Connect.Dulieutable(query);
            return re;
        }
        public bool ThemLoaiThuoc(String tenloaithuoc)
        {
            bool re = false;
            String query = "Insert into loaithuoc(tenloaithuoc) Values ('"+ tenloaithuoc +"')";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re;
        }
        public bool ThemThuoc(String tenthuoc,int idloaithuoc,String hansudung,int giatien,int soluong)
        {
            bool re = false;
            String query = "Insert into thuoc(tenthuoc,idloaithuoc,hansudung,giatien,soluong) Values ('" + tenthuoc + "','"+ idloaithuoc + "','"+ hansudung +"','"+ giatien +"','"+ soluong +"')";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable LoadThuoc()
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * From thuoc";
            re = Connect.Dulieutable(query);
            return re;
        }
        public bool XoaThuoc(int id)
        {
            bool re = false; 
            String query = "Delete From thuoc Where id = '"+ id + "'";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re;
        }
        public bool CapNhatThuoc(int id,String tenthuoc,int idloaithuoc,String hansudung,int giatien,int soluong)
        {
            bool re = false;
            String query = "Update thuoc Set tenthuoc = '"+tenthuoc+"',idloaithuoc = '"+idloaithuoc+"',hansudung = '"+hansudung+"',giatien = '"+giatien+"',soluong = '"+soluong+"' Where id = '"+id+"'";
            if(Connect.ExeCuteNonquery(query) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable LoadThuocVoiIDloaithuoc(int idloaithuoc)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * From thuoc Where idloaithuoc = '"+idloaithuoc+"'";
            re = Connect.Dulieutable(query);
            return re;
        }
        public DataTable TimKiemThuocVoiIDloaithuoc(int idloaithuoc,String tmp)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * From thuoc Where tenthuoc Like '%"+tmp+"%' And idloaithuoc = '"+idloaithuoc+"'";
            re = Connect.Dulieutable(query);
            return re;
        }
        public DataTable TimKiemThuoc(String tmp)
        {
            DataTable re;
            re = new DataTable();
            String query = "Select * From thuoc Where tenthuoc Like '%" + tmp + "%'";
            re = Connect.Dulieutable(query);
            return re;
        }
        public DataTable Load_thuocbenhan(int idbenhan)
        {
            DataTable re;
            re = new DataTable();
            String query = "SELECT id,tenthuoc,giatien FROM thuoc WHERE id IN ( SELECT idthuoc FROM thuocbenhan WHERE idbenhan = '"+idbenhan+"' )";
            re = Connect.Dulieutable(query);
            return re; 
        }
    }
}
