using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyBenhNhan
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFormDangNhap);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openFormDangNhap()
        {
            Application.Run(new Form2());
        }
    }
}
