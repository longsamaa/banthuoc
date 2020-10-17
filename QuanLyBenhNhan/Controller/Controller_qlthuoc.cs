using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLyBenhNhan.Model;
using System.Data;
using MySql.Data.MySqlClient;
namespace QuanLyBenhNhan.Controller
{
    class Controller_qlthuoc
    {
        Model_qlthuoc model_qlthuoc = new Model_qlthuoc();
        public DataTable LoadLoaiThuoc()
        {
            DataTable re;
            re = new DataTable();
            re = model_qlthuoc.loadLoaiThuoc();
            return re;
        }
        public bool ThemLoaiThuoc(String tenloaithuoc)
        {
            return model_qlthuoc.ThemLoaiThuoc(tenloaithuoc);
        }
        public bool ThemThuoc(String tenthuoc,int idloaithuoc,String hansudung,int giatien,int soluong)
        {
            return model_qlthuoc.ThemThuoc(tenthuoc, idloaithuoc, hansudung, giatien, soluong);
        }
        public DataTable LoadThuoc()
        {
            DataTable re;
            re = new DataTable();
            re = model_qlthuoc.LoadThuoc();
            return re;
        }
        public bool XoaThuoc(int id)
        {
            return model_qlthuoc.XoaThuoc(id);
        }
        public bool CapNhatThuoc(int id,String tenthuoc, int idloaithuoc, String hansudung, int giatien, int soluong)
        {
            return model_qlthuoc.CapNhatThuoc(id,tenthuoc, idloaithuoc, hansudung, giatien, soluong);
        }
        public DataTable LoadThuocVoiIDloaithuoc(int idloaithuoc)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlthuoc.LoadThuocVoiIDloaithuoc(idloaithuoc);
            return re;
        }
        public DataTable TimKiemThuocVoiIDloaithuoc(int idloaithuoc,string tmp)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlthuoc.TimKiemThuocVoiIDloaithuoc(idloaithuoc, tmp);
            return re; 
        }
        public DataTable Load_thuocbenhan(int idbenhan)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlthuoc.Load_thuocbenhan(idbenhan);
            return re; 
        }
        public DataTable TimKiemThuoc(String tmp)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlthuoc.TimKiemThuoc(tmp);
            return re; 
        }
    }
}
