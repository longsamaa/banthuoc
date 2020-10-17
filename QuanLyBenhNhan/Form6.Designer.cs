namespace QuanLyBenhNhan
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttenloaithuoc = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên loại thuốc :";
            // 
            // txttenloaithuoc
            // 
            this.txttenloaithuoc.Location = new System.Drawing.Point(168, 59);
            this.txttenloaithuoc.Name = "txttenloaithuoc";
            this.txttenloaithuoc.Size = new System.Drawing.Size(198, 20);
            this.txttenloaithuoc.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(47, 114);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(143, 23);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(223, 114);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(143, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 188);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttenloaithuoc);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Thêm thuốc";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenloaithuoc;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
    }
}