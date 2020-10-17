using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QuanLyBenhNhan.Model;
using MySql.Data.MySqlClient;
using QuanLyBenhNhan.Controller;
using System.Threading;

namespace QuanLyBenhNhan
{
    public partial class Form2 : Form
    {
        Thread th;
        Controller_qlbn controller = new Controller_qlbn();
        public delegate void SendTable(DataTable tb);
        public static DataTable dt; // Luu bang tai khoan da load
        public SendTable Sender;
        public Form2()
        {
            InitializeComponent();
            txtmatkhau.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap2_Click(object sender, EventArgs e)
        {
            String taikhoan = txttaikhoan.Text;
            String matkhau = txtmatkhau.Text;
            DataTable db;
            db = new DataTable();
            db = controller.loadTaikhoan(taikhoan, matkhau); //Load tai khoan
            dt = db;
            if (db.Rows.Count != 0)
            {
                //Sender = new SendTable(getTaBle);
                //Sender(db); // Gui table qua form khac
                this.Close();
                th = new Thread(openFormGiaoDien);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Ban da nhap sai mat khau hoac tai khoan", "Warning", MessageBoxButtons.OKCancel);
                if(dlr == DialogResult.OK || dlr == DialogResult.Cancel)
                {
                    txtmatkhau.Text = "";
                }
            }
        }

        private void getTaBle(DataTable tb)
        {
            tb = dt;
        }

        private void openFormGiaoDien()
        {
            Application.Run(new Form3());
        }
    }
}
