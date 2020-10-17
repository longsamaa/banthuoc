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
using System.Threading;
namespace QuanLyBenhNhan
{
    public partial class Form5 : Form
    {
        Thread th;
        Controller_qlthuoc controller = new Controller_qlthuoc();
        bool formloading = true;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnlammoi.Enabled = false;
            LoadThuoc();
            LoadLoaiThuoc();
            LoadLoaiThuoc2();
            btncapnhat.Enabled = false;
            btnxoa.Enabled = false;
            //comboBox2.Text = "";
            formloading = false;
        }
        public void LoadLoaiThuoc()
        {
            DataTable db = new DataTable();
            db = controller.LoadLoaiThuoc();
            int numRows = db.Rows.Count;
            comboBox1.DataSource = db;
            comboBox1.DisplayMember = "tenloaithuoc";
            comboBox1.ValueMember = "id";
        }

        public void LoadLoaiThuoc2()
        {
            DataTable db = new DataTable();
            db = controller.LoadLoaiThuoc();
            int numRows = db.Rows.Count;
            comboBox2.DataSource = db;
            comboBox2.DisplayMember = "tenloaithuoc";
            comboBox2.ValueMember = "id";
            //comboBox2.Items.Add("khong co gi");
        }

        public void LoadThuoc()
        {
            DataTable db;
            db = new DataTable();
            db = controller.LoadThuoc();
            dataGridViewThuoc.DataSource = db;
        }

        private void btnthemloaithuoc_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = true;
            th = new Thread(openformThemLoaiThuoc);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openformThemLoaiThuoc()
        {
            Application.Run(new Form6());
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = false;
            LoadLoaiThuoc();
            LoadLoaiThuoc2();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txttenthuoc.Text == "" || comboBox1.Text == "" || dateTimePicker1.Text == "" || txtgiatien.Text == "" || txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn đã nhập sai xin mời nhập lại?", "Warning", MessageBoxButtons.OKCancel);
            }
            else
            {
                String tenthuoc = txttenthuoc.Text;
                int idloaithuoc = Convert.ToInt32(comboBox1.SelectedValue);
                DateTime hansudung = Convert.ToDateTime(dateTimePicker1.Text);
                int giatien = Convert.ToInt32(txtgiatien.Text);
                int soluong = Convert.ToInt32(txtsoluong.Text);
                bool kt = controller.ThemThuoc(tenthuoc, idloaithuoc, hansudung.ToString(), giatien, soluong);
                if (kt)
                {
                    DialogResult dlg = MessageBox.Show("Đã thêm thành công", "Complete", MessageBoxButtons.OKCancel);
                    LoadThuoc();
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Thêm thất bại xin mời nhập lại", "Complete", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc này không ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = (int)dataGridViewThuoc.SelectedRows[0].Cells[0].Value;
            bool kt = controller.XoaThuoc(id);
            if (kt)
            {
                DialogResult dlr = MessageBox.Show("Xóa thành công", "Completed", MessageBoxButtons.OKCancel);
                LoadThuoc();
                btnxoa.Enabled = false;
                btncapnhat.Enabled = false;
                txttenthuoc.Text = "";
                comboBox1.Text = "";
                txtgiatien.Text = "";
                txtsoluong.Text = "";
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Xóa không thành công", "Completed", MessageBoxButtons.OKCancel);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (txttenthuoc.Text == "" || comboBox1.Text == "" || dateTimePicker1.Text == "" || txtgiatien.Text == "" || txtsoluong.Text == "")
            {
               MessageBox.Show("Bạn đã nhập sai mời nhập lại", "Warning", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn cập nhât thuốc này không ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            int id = (int)dataGridViewThuoc.SelectedRows[0].Cells[0].Value;
            String tenthuoc = txttenthuoc.Text;
            int idloaithuoc = Convert.ToInt32(comboBox1.SelectedValue);
            DateTime hansudung = Convert.ToDateTime(dateTimePicker1.Text);
            int giatien = Convert.ToInt32(txtgiatien.Text);
            int soluong = Convert.ToInt32(txtsoluong.Text);
            bool kt = controller.CapNhatThuoc(id, tenthuoc, idloaithuoc, hansudung.ToString(), giatien, soluong);
            if (kt)
            {
                DialogResult dlr = MessageBox.Show("Cập nhật thành công", "Completed", MessageBoxButtons.OKCancel);
                LoadThuoc();
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Cập nhật không thành công", "Completed", MessageBoxButtons.OKCancel);
            }
        }

        private void dataGridViewThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewThuoc.SelectedRows.Count > 0)
            {
                //if ((String)dataGridViewThuoc.SelectedRows[0].Cells[0].Value != "id"){
                    String tenthuoc = (String)dataGridViewThuoc.SelectedRows[0].Cells[1].Value;
                    int idloaithuoc = (int)dataGridViewThuoc.SelectedRows[0].Cells[2].Value;
                    String hansudung = (String)dataGridViewThuoc.SelectedRows[0].Cells[3].Value;
                    int giatien = (int)dataGridViewThuoc.SelectedRows[0].Cells[4].Value;
                    int soluong = (int)dataGridViewThuoc.SelectedRows[0].Cells[5].Value;

                    txttenthuoc.Text = tenthuoc;
                    comboBox1.SelectedValue = idloaithuoc;
                    txtgiatien.Text = giatien.ToString();
                    txtsoluong.Text = soluong.ToString();

                btnxoa.Enabled = true;
                btncapnhat.Enabled = true;
                //}
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFormgiaodien);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openFormgiaodien()
        {
            Application.Run(new Form3());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formloading == false)
            {
                int id = Convert.ToInt32(comboBox2.SelectedValue);
                if (id == 8)
                {
                    LoadThuoc();
                }
                else
                {
                    DataTable db = new DataTable();
                    db = controller.LoadThuocVoiIDloaithuoc(id);
                    dataGridViewThuoc.DataSource = db;
                }
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String tmp = txtsearch.Text;
            int idloaithuoc = Convert.ToInt32(comboBox2.SelectedValue);
            DataTable db = new DataTable();
            if (idloaithuoc == 8)
            {
                //LoadThuoc();
                db = controller.TimKiemThuoc(tmp);
                dataGridViewThuoc.DataSource = db; 
            }
            else
            {
                db = controller.TimKiemThuocVoiIDloaithuoc(idloaithuoc, tmp);
                dataGridViewThuoc.DataSource = db;
            }
        }
    }
}
