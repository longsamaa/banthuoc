using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QuanLyBenhNhan.Controller;
using System.Threading;

namespace QuanLyBenhNhan
{
    public partial class Form7 : Form
    {
        Controller_qlbenhan controller_qlbenhan = new Controller_qlbenhan();
        Controller_qlthuoc controller_qlthuoc = new Controller_qlthuoc();
        Controller_Thuocbenhan Controller_Thuocbenhan = new Controller_Thuocbenhan(); 
        bool formLoading = true;
        DataTable   dbthuoc;
        Thread th; 
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //Load ten benh nhan

            Loaddulieu();
            //Form da load xong
            formLoading = false;
            //
        }

        String imgLocation = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
               // pictureBox1.Image = Image.FromFile(opf.FileName);
                imgLocation = opf.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
  
        private void btnThemBenhAn_Click(object sender, EventArgs e)
        {
            bool kt = ThemBenhAn();
            ThemThuocBenhAn();
            if (kt)
            {
                Exit();
            }
            else
            {
                MessageBox.Show("Bạn thêm không thành công", "Cảnh báo", MessageBoxButtons.OKCancel);
                return; 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(formLoading == false)
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                DataTable re = new DataTable();
                re = controller_qlthuoc.LoadThuocVoiIDloaithuoc(id);
                dataGridView1.DataSource = re; 
            }
        }

        private void txttimkiemthuoc_TextChanged(object sender, EventArgs e)
        {
            int idloadthuoc = Convert.ToInt32(comboBox1.SelectedValue);
            String tmp = txttimkiemthuoc.Text;
            DataTable re = new DataTable();
            re = controller_qlthuoc.TimKiemThuocVoiIDloaithuoc(idloadthuoc, tmp);
            dataGridView1.DataSource = re; 
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btnxoadbthuoc_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                String strid = id.ToString();
                DataRow[] drr = dbthuoc.Select("id = '" + strid + "'");
                for (int i = 0; i < drr.Length; i++)
                    drr[i].Delete();
                dbthuoc.AcceptChanges();
            }
            dataGridView2.DataSource = dbthuoc;
            btnxoadbthuoc.Enabled = false; 
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                btnxoadbthuoc.Enabled = true; 
            }
        }

        private void btnthemthuoc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (Controller_Thuocbenhan.Kiemtrasoluong(txtSoluong.Text))
                {
                    String tenthuoc = (String)dataGridView1.SelectedRows[0].Cells[1].Value;
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    int giatien = (int)dataGridView1.SelectedRows[0].Cells[4].Value;
                    int soluong = Convert.ToInt32(txtSoluong.Text);
                    int idthuoc = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    if (Controller_Thuocbenhan.CapNhatDBThuoc(dbthuoc, idthuoc))
                    {
                        String strid = idthuoc.ToString();
                        DataRow[] drr = dbthuoc.Select("id = '" + strid + "'");
                        drr[0]["soluong"] = Convert.ToInt32(drr[0]["soluong"]) + soluong;
                        dbthuoc.AcceptChanges();
                        dataGridView2.DataSource = dbthuoc;
                    }
                    else
                    {
                        String tmp = txtSoluong.Text;
                        if (Controller_Thuocbenhan.Kiemtrasoluong(tmp))
                        {

                            //Add gia tri vao bang 

                            dbthuoc.Rows.Add(id, tenthuoc, giatien, soluong);

                            dataGridView2.DataSource = dbthuoc;
                        }
                    }
                }
            }
        }

        private void Loaddulieu()
        {
            txtid.Text = Form4.tmp6.ToString();
            txtten.Text = Form4.tmp2;
            txtdiachi.Text = Form4.tmp4;
            txtngaykham.Text = Form4.tmp5;
            LoadLoaiThuoc();
            initlistthuoc();

            //load hinh anh

            DataTable re = new DataTable();
            re = controller_qlbenhan.Load_hinhanhIdbenhnhan(Form4.tmp6);
            if (re.Rows.Count > 0)
            {
                byte[] img = (byte[])re.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                button1.Enabled = false;
            }
            btnxoadbthuoc.Enabled = false;
        }

        private void initlistthuoc()
        {
            dbthuoc = new DataTable();
            dbthuoc.Columns.Add("id", typeof(int));
            dbthuoc.Columns.Add("tenthuoc", typeof(String));
            dbthuoc.Columns.Add("giatien", typeof(int));
            dbthuoc.Columns.Add("soluong", typeof(int));
        }

        private void LoadLoaiThuoc()
        {
            DataTable re;
            re = new DataTable();
            re = controller_qlthuoc.LoadLoaiThuoc();
            comboBox1.DataSource = re;
            comboBox1.DisplayMember = "tenloaithuoc";
            comboBox1.ValueMember = "id";
        }

        private void Exit()
        {
            this.Close();
            //th = new Thread(OpenFormbenhnhan);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
        }

        private void OpenFormbenhnhan()
        {
            Application.Run(new Form4());
        }

        private void ThemThuocBenhAn()
        {
            //Them datatable thuoc benh an vao trong csdl 
            int idbenhan = Load_idbenhan();
            int dem = 0;
            foreach (DataRow dr in dbthuoc.Rows)
            {
                dem++;
                int idthuoc = Convert.ToInt32(dr["id"]);
                int soluong = Convert.ToInt32(dr["soluong"]);
                Controller_Thuocbenhan.Themthuocbenhan(idbenhan, idthuoc, soluong);
                Console.WriteLine(idbenhan);
                Console.WriteLine(idthuoc.ToString(), soluong);
            }
        }

        private int Load_idbenhan()
        {
            DataTable re;
            int idbenhan = 0;
            re = new DataTable();
            re = controller_qlbenhan.Load_idbenhan();
            foreach (DataRow dr in re.Rows)
            {
                idbenhan = Convert.ToInt32(dr["id"]);
            }
            return idbenhan;
        }

        private bool ThemBenhAn()
        {
            //Lay hinh anh
            MemoryStream ms = new MemoryStream();
            bool re = false;
            if (pictureBox1.Image == null || txttrieuchung.Text == "" || dbthuoc.Rows.Count == 0)
            {
                DialogResult dlr = MessageBox.Show("Hình như bạn nhập chưa đầy đủ", "Warning", MessageBoxButtons.OKCancel);
            }
            else
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                //Lay cai khac 
                int idbenhnhan = Convert.ToInt32(txtid.Text);
                String trieuchung = txttrieuchung.Text;
                //Them vao CSDL
                bool kt = controller_qlbenhan.ThemBenhAn(idbenhnhan, img, trieuchung);
                if (kt)
                {
                    DialogResult dlr = MessageBox.Show("Ban them thanh cong", "Completed", MessageBoxButtons.OKCancel);
                    re = true;
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Ban them khong thanh cong", "Completed", MessageBoxButtons.OKCancel);
                }
            }
            return re;
        }
    }
}
