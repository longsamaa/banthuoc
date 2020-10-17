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
using QuanLyBenhNhan.Model;
using System.Threading;
namespace QuanLyBenhNhan
{
    public partial class Form4 : Form
    {
        Thread th;
        Controller_qlbn controller = new Controller_qlbn();
        Controller_qlbenhan controller_qlbenhan = new Controller_qlbenhan(); 
        public static DataTable search;
        String tmp1 = "hoten";
        public static String tmp2;
        public static String tmp3;
        public static String tmp4;
        public static String tmp5;
        public static int tmp6; 
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadBenhNhan();
            Vohieuhoanut();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            String hoten = txthoten.Text;
            String gioitinh = txtgioitinh.Text;
            String diachi = txtdiachi.Text;
            DateTime ngaykham = Convert.ToDateTime(dateTimePicker1.Text);
            if(hoten == "" || gioitinh == "" || diachi == "" || ngaykham == null)
            {
                DialogResult dlr = MessageBox.Show("Ban nhap khong dung moi nhap lai", "Warning", MessageBoxButtons.OKCancel);
            }
            else
            {
                bool kt = controller.ThemBenhNhan(hoten, gioitinh, diachi, ngaykham.ToString());
                if (kt)
                {
                    DialogResult dlr1 = MessageBox.Show("Bạn đã thêm thành công","Complete", MessageBoxButtons.OKCancel);
                    loadBenhNhan();
                    txthoten.Text = "";
                    txtgioitinh.Text = "";
                    txtdiachi.Text = "";
                }
                else
                {
                    DialogResult dlr1 = MessageBox.Show("Bạn đã thêm không thành công", "Warning", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này không ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = (int)dataGridViewbenhnhan.SelectedRows[0].Cells[0].Value;
            bool kt = controller.XoaBenhNhan(id);
            if (kt)
            {
                DialogResult dlr1 = MessageBox.Show("Bạn đã xóa thành công", "Complete", MessageBoxButtons.OKCancel);
                loadBenhNhan();
            }
            else
            {
                DialogResult dlr1 = MessageBox.Show("Bạn đã xóa không thành công xin thử lại", "Warning", MessageBoxButtons.OKCancel);
            }
        }

        private void dataGridViewbenhnhan_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewbenhnhan.SelectedRows.Count > 0)
            {
                String hoten = (String)dataGridViewbenhnhan.SelectedRows[0].Cells[1].Value;
                String gioitinh = (String)dataGridViewbenhnhan.SelectedRows[0].Cells[2].Value;
                String diachi = (String)dataGridViewbenhnhan.SelectedRows[0].Cells[3].Value;
                String ngaykham = (String)dataGridViewbenhnhan.SelectedRows[0].Cells[4].Value;
                txthoten.Text = hoten;
                txtgioitinh.Text = gioitinh;
                txtdiachi.Text = diachi;

                //kich hoat nut bam

                Kichhoatnutbam();

                //Gan gia tri cho cac bien static 
                gangiatriStatic(hoten, gioitinh, diachi, ngaykham, Convert.ToInt32(dataGridViewbenhnhan.SelectedRows[0].Cells[0].Value));
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật lại thông tin của bệnh nhân này không ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            String hoten = txthoten.Text;
            String gioitinh = txtgioitinh.Text;
            String diachi = txtdiachi.Text;
            DateTime ngaykham = Convert.ToDateTime(dateTimePicker1.Text);
            int id = (int)dataGridViewbenhnhan.SelectedRows[0].Cells[0].Value;
            bool kt = controller.CapNhatBenhNhan(id, hoten, gioitinh, diachi, ngaykham.ToString());
            if (kt)
            {
                DialogResult dlr1 = MessageBox.Show("Bạn đã cập nhật thành công", "Complete", MessageBoxButtons.OKCancel);
                loadBenhNhan();
            }
            else
            {
                DialogResult dlr1 = MessageBox.Show("Cập nhật không thành công xin thử lại", "Warning", MessageBoxButtons.OKCancel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFormGiaoDien);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            //tmp1 = "hoten";
            int dem = 0;
            int id = 0;
            string temp = comboBox1.Text;
            if (temp == "Họ và tên")
            {
                dem = 0;
            }
            if(temp == "Địa chỉ")
            {
                dem = 1;
            }
            if(temp == "Ngày khám")
            {
                dem = 2;
            }
            if(temp == "id")
            {
                dem = 3;
                if (txttimkiem.Text != "")
                {
                    id = Convert.ToInt32(txttimkiem.Text);
                }
            }
            String tmp1 = txttimkiem.Text;
         
            search = new DataTable();
            search = controller.TimKiemBenhNhan(tmp1,id,dem);
            dataGridViewbenhnhan.DataSource = search;
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
          
        }

        private void btnlapbenhan_Click(object sender, EventArgs e)
        {
            th = new Thread(openFormBenhAn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnxembenhan_Click(object sender, EventArgs e)
        {
            if (dataGridViewbenhnhan.SelectedRows.Count > 0)
            {
                int idbenhnhan = (int)dataGridViewbenhnhan.SelectedRows[0].Cells[0].Value;
                KtBenhanbenhnhan(idbenhnhan);
            }
        }

        private void KtBenhanbenhnhan(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable();
            re = controller_qlbenhan.Load_BenhanIdbenhnhan(idbenhnhan);
            if(re.Rows.Count == 0)
            {
                MessageBox.Show("Bệnh nhân này vẫn chưa có bệnh án ?", "Warning", MessageBoxButtons.YesNo);
                return;
            }
            else
            {
                Moformbenhan(); 
            }
        }

        private void Moformbenhan()
        {
            th = new Thread(openFormsobenhan);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openFormsobenhan()
        {
            Application.Run(new Form8());
        }

        private void Kichhoatnutbam()
        {
            btncapnhat.Enabled = true;
            btnxoa.Enabled = true;
            btnlapbenhan.Enabled = true;
            btnxembenhan.Enabled = true;
        }
        private void gangiatriStatic(String hoten, String gioitinh, String diachi, String ngaykham, int idbenhnhan)
        {
            tmp2 = hoten;
            tmp3 = gioitinh;
            tmp4 = diachi;
            tmp5 = ngaykham;
            tmp6 = idbenhnhan;
        }

        private void openFormBenhAn()
        {
            Application.Run(new Form7());
        }

        private void openFormGiaoDien()
        {
            Application.Run(new Form3());
        }

        private void Vohieuhoanut()
        {
            if (dataGridViewbenhnhan.SelectedRows.Count == 0)
            {
                btncapnhat.Enabled = false;
                btnxoa.Enabled = false;
                btnlapbenhan.Enabled = false;
                btnxembenhan.Enabled = false;
            }
        }

        private void loadBenhNhan() //Load benh nhan tren man hinh
        {
            DataTable db = new DataTable();
            DataTable db2 = new DataTable();
            db = controller.LoadBenhNhan();
            dataGridViewbenhnhan.DataSource = db;
        }
    }
}
