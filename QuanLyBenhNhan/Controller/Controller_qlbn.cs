using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBenhNhan.Model;

namespace QuanLyBenhNhan.Controller
{
    class Controller_qlbn
    {
        Model_qlbn model_qlbn = new Model_qlbn();
        public DataTable loadTaikhoan(String taikhoan,String matkhau) // Load tai khoan voi tai khoan va mat khau
        {
            DataTable re;
            re = new DataTable();
            re = model_qlbn.loadTaikhoan(taikhoan, matkhau);
            return re;
        }
        public bool ThemBenhNhan(String hovaten,String gioitinh,String diachi,String ngaykham)
        {
            return model_qlbn.ThemBenhNhan(hovaten, gioitinh, diachi, ngaykham);
        }
        public DataTable LoadBenhNhan()
        {
            DataTable re;
            re = new DataTable();
            re = model_qlbn.LoadBenhNhan();
            return re;
        }
        public bool XoaBenhNhan(int id)
        {
            return model_qlbn.XoaBenhNhan(id);
        }
        public bool CapNhatBenhNhan(int id ,String hoten,String gioitinh,String diachi,String ngaykham)
        {
            return model_qlbn.CapNhatBenhNhan(id, hoten, gioitinh, diachi, ngaykham);
        }
        public DataTable TimKiemBenhNhan(String tmp,int id,int dem)
        {
            return model_qlbn.TimKiemBenhNhan(tmp,id,dem);
        }
    }
}
