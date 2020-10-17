using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBenhNhan.Model;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBenhNhan.Controller
{
    class Controller_Thuocbenhan
    {
        Model_Thuocbenhan model_Thuocbenhan = new Model_Thuocbenhan(); 
        public bool Themthuocbenhan(int idbenhan,int idthuoc,int soluong)
        {
            return model_Thuocbenhan.Themthuocbenhan(idbenhan, idthuoc, soluong);
        }
        public bool Kiemtrasoluong(String soluong)
        {
            bool re = true;
            if (soluong == "")
            {
                re = false;
            }
            else
            {
                char c; 
                for(int i = 0; i < soluong.Length; i++)
                {
                    c = soluong[i];
                    if(Convert.ToInt16(c) > 57 || Convert.ToInt16(c) < 48)
                    {
                        re = false; 
                    }
                }
            }
            return re;
        }
        public DataRow[] ktThuoc(DataTable db ,int id)
        {
            String strid = id.ToString();
            DataRow[] drr = db.Select("id = '" + strid + "'");
            return drr;
        }
        public bool CapNhatDBThuoc(DataTable db, int id)
        {
            bool re;
            re = false;
            DataRow[] drr = ktThuoc(db, id); 
            if(drr.Length > 0)
            {
                if (MessageBox.Show("Bạn có muốn thêm thuốc này nữa không ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    re = false; 
                }
                else
                {
                    re = true; 
                }
            }
            return re; 
        }
        public DataTable Load_soluongthuocbenhan(int idbenhan, int idthuoc)
        {
            DataTable re;
            re = new DataTable();
            re = model_Thuocbenhan.Load_soluongthuocbenhan(idbenhan, idthuoc);
            return re; 
        }
    }
}
