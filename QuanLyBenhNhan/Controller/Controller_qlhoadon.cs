using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBenhNhan.Model;
using System.Data;

namespace QuanLyBenhNhan.Controller
{
    class Controller_qlhoadon
    {
        Model_qlhoadon model_qlhoadon = new Model_qlhoadon();
        public bool ThemHoaDon(int idbenhan, int tongtien,String ngaythang)
        {
            return model_qlhoadon.ThemHoaDon(idbenhan, tongtien,ngaythang);
        }
        public DataTable Loadhoadon(int idbenhan)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlhoadon.Loadhoadon(idbenhan);
            return re; 
        }
    }
}
