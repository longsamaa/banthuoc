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
    public partial class Form3 : Form
    {
        Thread th;
        Thread th1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String name = Form2.dt.Rows[0][3].ToString();
            txtten.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFormquanly);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openFormquanly()
        {
            Application.Run(new Form4());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th1 = new Thread(openFormquanlythuoc);
            th1.SetApartmentState(ApartmentState.STA);
            th1.Start();
        }

        private void openFormquanlythuoc()
        {
            Application.Run(new Form5());
        }
    }
}
