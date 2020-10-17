namespace QuanLyBenhNhan
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridViewbenhnhan = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnlapbenhan = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnxembenhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewbenhnhan
            // 
            this.dataGridViewbenhnhan.AllowUserToAddRows = false;
            this.dataGridViewbenhnhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbenhnhan.Location = new System.Drawing.Point(25, 192);
            this.dataGridViewbenhnhan.Name = "dataGridViewbenhnhan";
            this.dataGridViewbenhnhan.Size = new System.Drawing.Size(607, 404);
            this.dataGridViewbenhnhan.TabIndex = 0;
            this.dataGridViewbenhnhan.SelectionChanged += new System.EventHandler(this.dataGridViewbenhnhan_SelectionChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(414, 146);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(218, 31);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            this.txttimkiem.Leave += new System.EventHandler(this.txttimkiem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm theo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách bệnh nhân";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quản lý bệnh nhân";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(710, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ và tên :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(710, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa chỉ :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(710, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày khám :";
            // 
            // btnthem
            // 
            this.btnthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnthem.Location = new System.Drawing.Point(827, 360);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(184, 57);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm bệnh nhân";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnxoa.Location = new System.Drawing.Point(827, 445);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(184, 56);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa bệnh nhân";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncapnhat.Location = new System.Drawing.Point(1143, 360);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(175, 57);
            this.btncapnhat.TabIndex = 11;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnlapbenhan
            // 
            this.btnlapbenhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlapbenhan.Location = new System.Drawing.Point(1143, 445);
            this.btnlapbenhan.Name = "btnlapbenhan";
            this.btnlapbenhan.Size = new System.Drawing.Size(175, 56);
            this.btnlapbenhan.TabIndex = 12;
            this.btnlapbenhan.Text = "Lập bệnh án";
            this.btnlapbenhan.UseVisualStyleBackColor = true;
            this.btnlapbenhan.Click += new System.EventHandler(this.btnlapbenhan_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(919, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(399, 38);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txthoten
            // 
            this.txthoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthoten.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(871, 84);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(447, 36);
            this.txthoten.TabIndex = 14;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgioitinh.Location = new System.Drawing.Point(871, 157);
            this.txtgioitinh.Multiline = true;
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(447, 36);
            this.txtgioitinh.TabIndex = 15;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(871, 229);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(447, 38);
            this.txtdiachi.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(1143, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "id",
            "Họ và tên",
            "Địa chỉ",
            "Ngày khám"});
            this.comboBox1.Location = new System.Drawing.Point(167, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tìm kiếm :";
            // 
            // btnxembenhan
            // 
            this.btnxembenhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnxembenhan.Location = new System.Drawing.Point(827, 540);
            this.btnxembenhan.Name = "btnxembenhan";
            this.btnxembenhan.Size = new System.Drawing.Size(184, 56);
            this.btnxembenhan.TabIndex = 20;
            this.btnxembenhan.Text = "Xem bệnh án";
            this.btnxembenhan.UseVisualStyleBackColor = true;
            this.btnxembenhan.Click += new System.EventHandler(this.btnxembenhan_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1362, 608);
            this.Controls.Add(this.btnxembenhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnlapbenhan);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dataGridViewbenhnhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý bệnh nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbenhnhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewbenhnhan;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnlapbenhan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnxembenhan;
    }
}