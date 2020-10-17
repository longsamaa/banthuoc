using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhNhan.Controller; 


namespace QuanLyBenhNhan
{
    public partial class Form9 : Form
    {
        Controller_qlthuoc controller_qlthuoc = new Controller_qlthuoc();
        Controller_Thuocbenhan controller_Thuocbenhan = new Controller_Thuocbenhan();
        Controller_qlhoadon controller_qlhoadon = new Controller_qlhoadon();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Loadthuocbenhnhan();
        }

        private void Loadthuocbenhnhan()
        {
            //Tao bang de luu
            //Tao bang de luu
            DataTable db;
            db = new DataTable();
            db.Columns.Add("Tên thuốc", typeof(String));
            db.Columns.Add("Giá cả", typeof(int));
            db.Columns.Add("Số lượng", typeof(int));
            DataTable re;
            re = new DataTable();
            re = controller_qlthuoc.Load_thuocbenhan(Form8.idbenhanstatic);
            // Lay gia tri cua bang thuoc
            DataTable soluong = new DataTable(); // Bang luu so luong cua thuoc
            foreach (DataRow dr in re.Rows)
            {
                soluong = controller_Thuocbenhan.Load_soluongthuocbenhan(Form8.idbenhanstatic, Convert.ToInt32(dr["id"]));
                db.Rows.Add(dr["tenthuoc"].ToString(), Convert.ToInt32(dr["giatien"]), Convert.ToInt32(soluong.Rows[0][0])); // Add ten thuoc , gia tien , so luong vao trong bang 
            }
            dataGridView1.DataSource = db;
            //Tinh tien
            int tienthanhtoan = 0;
            foreach (DataRow dr in db.Rows)
            {
                tienthanhtoan = tienthanhtoan + Convert.ToInt32(dr["Giá cả"]) * Convert.ToInt32(dr["Số lượng"]);
            }
            txttongtien.Text = tienthanhtoan.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idbenhan = Form8.idbenhanstatic;
            if (Kt_hoadon(idbenhan))
            {
                int tongtien = Convert.ToInt32(txttongtien.Text);
                DateTime ngaythang = new DateTime();
                ngaythang = DateTime.Now;
                bool kt = controller_qlhoadon.ThemHoaDon(idbenhan, tongtien,ngaythang.ToString());
                if (kt)
                {
                    MessageBox.Show("Xác nhận thành công", "Thành công", MessageBoxButtons.OKCancel);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xác nhận không thành công", "Thành công", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Bệnh án này đã xác nhận rồi", "Thành công");
                this.Close();
            }
        }
        private bool Kt_hoadon(int idbenhan)
        {
            bool kt = false;
            DataTable re = new DataTable();
            re = controller_qlhoadon.Loadhoadon(idbenhan);
            if(re.Rows.Count == 0)
            {
                kt = true;
            }
            return kt; 
        }
    }
}
