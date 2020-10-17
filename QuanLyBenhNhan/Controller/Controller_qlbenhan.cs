using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBenhNhan.Model;
using System.Data;

namespace QuanLyBenhNhan.Controller
{
    
    class Controller_qlbenhan
    {
        Model_qlbenhan model_qlbenhan = new Model_qlbenhan();
        public bool ThemBenhAn(int idbenhnhan,byte[] image,String trieuchung)
        {
            return model_qlbenhan.Them_BenhAn(idbenhnhan, image, trieuchung);
        }
        public DataTable LoadBenhAnIDbenhan(int id)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlbenhan.Load_BenhAnIDBenhAn(id);
            return re;
        }
        public DataTable Load_idbenhan()
        {
            DataTable re;
            re = new DataTable();
            re = model_qlbenhan.Load_idbenhan();
            return re; 
        }
        public DataTable Load_BenhanIdbenhnhan(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlbenhan.Load_BenhanIdbenhnhan(idbenhnhan);
            return re; 
        }
        public DataTable Load_hinhanhIdbenhnhan(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlbenhan.Load_hinhanhIdbenhnhan(idbenhnhan);
            return re; 
        }
        public DataTable Load_TrieuchungIdbenhan(int idbenhan)
        {
            DataTable re;
            re = new DataTable();
            re = model_qlbenhan.Load_TrieuchungIdbenhan(idbenhan);
            return re; 
        }
        public bool Xoa_Benhan(int idbenhan)
        {
            return model_qlbenhan.Xoa_Benhan(idbenhan);
        }
    }
}
