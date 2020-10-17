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
using System.IO;
using System.Threading; 

namespace QuanLyBenhNhan
{
    public partial class Form8 : Form
    {
        Controller_qlbenhan controller_qlbenhan = new Controller_qlbenhan();
        Controller_qlthuoc controller_qlthuoc = new Controller_qlthuoc();
        Controller_Thuocbenhan controller_Thuocbenhan = new Controller_Thuocbenhan();
        Thread th;
        public static int idbenhanstatic; 
        public static int tienthanhtoan; 
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            loadthuoctinhbenhnhan();
            txttienthanhtoan.Visible = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                int idbenhan = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                Console.WriteLine(idbenhan);
                Loadbinhluan(idbenhan);
                Loaddanhsachthuocbenhan(idbenhan);
                txttienthanhtoan.Text = tienthanhtoan.ToString();
                txttienthanhtoan.Visible = true; 
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh án này không ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idbenhan = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    bool kt = controller_qlbenhan.Xoa_Benhan(idbenhan);
                    if (kt)
                    {
                        MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OKCancel);
                        ktsobenhan();
                    }
                    else
                    {
                        MessageBox.Show("Bạn xóa không thành công", "Thông báo", MessageBoxButtons.OKCancel);
                    }
                }
            }
        }

        private void ktsobenhan()
        {
            int idbenhnhan = Convert.ToInt32(txtidbenhnhan.Text);
            DataTable re = new DataTable();
            re = loadDataGridview(idbenhnhan);
            if(re.Rows.Count == 0)
            {
                this.Close();
            }
            dataGridView1.DataSource = re; 
        }

        /// Cac ham can dung

        ///load id ,ten , hinh anh cua benh nhan tu database
        private void loadthuoctinhbenhnhan()
        {
            txtidbenhnhan.Text = Form4.tmp6.ToString();
            txtten.Text = Form4.tmp2;
            txtsoluong.Text = Demsoluongbenhan(Form4.tmp6).ToString();
            DatgiatriDatagridview(Form4.tmp6);
            txtdiachi.Text = Form4.tmp4;
            txtngaykham.Text = Form4.tmp5;
            DataTable re = new DataTable();
            re = controller_qlbenhan.Load_hinhanhIdbenhnhan(Form4.tmp6);
            if(re.Rows.Count > 0)
            {
                byte[] img = (byte[])re.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        //Load so luong benh an cua benh nhan len datagridview
        private void DatgiatriDatagridview(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable();
            re = controller_qlbenhan.Load_BenhanIdbenhnhan(idbenhnhan);
            dataGridView1.DataSource = re; 
        }
        //Ham load so luong benh an cua benh nhan len datatable
        private DataTable loadDataGridview(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable();
            re = controller_qlbenhan.Load_BenhanIdbenhnhan(idbenhnhan);
            return re; 
        }
        //ham dem so luong benh an cua benh nhan
        private int Demsoluongbenhan(int idbenhnhan)
        {
            DataTable re;
            re = new DataTable();
            re = loadDataGridview(idbenhnhan);
            return re.Rows.Count; 
        }
        //Ham load trieu chung cua benh nhan len o text
        private void Loadbinhluan(int idbenhan)
        {
            DataTable re;
            re = new DataTable(); 
            re = controller_qlbenhan.Load_TrieuchungIdbenhan(idbenhan);
            txttrieuchung.Text = re.Rows[0][0].ToString();
        }
        //Ham load danh sach thuoc cua benh nhan trong moi benh an 
        private void Loaddanhsachthuocbenhan(int idbenhan)
        {
            //Tao bang de luu
            DataTable db;
            db = new DataTable();
            db.Columns.Add("Tên thuốc", typeof(String));
            db.Columns.Add("Giá cả", typeof(int));
            db.Columns.Add("Số lượng", typeof(int));
            DataTable re;
            re = new DataTable();
            re = controller_qlthuoc.Load_thuocbenhan(idbenhan);
            // Lay gia tri cua bang thuoc
            DataTable soluong = new DataTable(); // Bang luu so luong cua thuoc
            foreach(DataRow dr in re.Rows){
                soluong = controller_Thuocbenhan.Load_soluongthuocbenhan(idbenhan, Convert.ToInt32(dr["id"]));
                db.Rows.Add(dr["tenthuoc"].ToString(),Convert.ToInt32(dr["giatien"]),Convert.ToInt32(soluong.Rows[0][0])); // Add ten thuoc , gia tien , so luong vao trong bang 
            }
            dataGridView2.DataSource = db;
            //Tinh tien
            tienthanhtoan = 0;
            foreach (DataRow dr in db.Rows)
            {
                tienthanhtoan = tienthanhtoan + Convert.ToInt32(dr["Giá cả"])*Convert.ToInt32(dr["Số lượng"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idbenhanstatic = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            th = new Thread(OpenFormThanhToan);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenFormThanhToan()
        {
            Application.Run(new Form9());
        }

        private void Vohieuhoanutbam()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                button1.Enabled = false;
                btnxoa.Enabled = false;
                button2.Enabled = false;
            }
        }
        
        private void Kichhoatnutbam()
        {
            button1.Enabled = true;
            btnxoa.Enabled = true;
            button2.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Kichhoatnutbam();
            }
        }
    }
}
