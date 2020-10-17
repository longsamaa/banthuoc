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
    public partial class Form6 : Form
    {
        Controller_qlthuoc controller = new Controller_qlthuoc();
        public static int kt = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            kt = 1;
            Form f = new Form5();
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            String tenloaithuoc = txttenloaithuoc.Text;
            bool kt = controller.ThemLoaiThuoc(tenloaithuoc);
            if (kt)
            {
                DialogResult dlg = MessageBox.Show("Đã thêm thành công", "Complete", MessageBoxButtons.OKCancel);
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Thêm không thành công", "Complete", MessageBoxButtons.OKCancel);
            }
        }
    }
}
