namespace desain_Rahma
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userDashboard1 = new desain_Rahma.UserDashboard();
            this.masterSiswa1 = new desain_Rahma.MasterSiswa();
            this.masterBuku1 = new desain_Rahma.MasterBuku();
            this.peminjamanBuku1 = new desain_Rahma.PeminjamanBuku();
            this.pengembalianBuku1 = new desain_Rahma.PengembalianBuku();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 767);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Noto Serif Georgian", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(3, 541);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(299, 83);
            this.button6.TabIndex = 5;
            this.button6.Text = "LOGOUT";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Noto Serif Georgian", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(3, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(299, 83);
            this.button5.TabIndex = 4;
            this.button5.Text = "Pengembalian Buku";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Noto Serif Georgian", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(-3, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(299, 83);
            this.button4.TabIndex = 3;
            this.button4.Text = "Peminjaman Buku";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Noto Serif Georgian", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(3, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "Master Buku";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Serif Georgian", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(3, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Master Siswa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Serif Georgian", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(3, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(299, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(980, 43);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.userDashboard1);
            this.panel2.Controls.Add(this.masterSiswa1);
            this.panel2.Controls.Add(this.masterBuku1);
            this.panel2.Controls.Add(this.peminjamanBuku1);
            this.panel2.Controls.Add(this.pengembalianBuku1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(299, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 656);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(305, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "WELCOME ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(485, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "admin";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // userDashboard1
            // 
            this.userDashboard1.Location = new System.Drawing.Point(-74, -15);
            this.userDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.userDashboard1.Name = "userDashboard1";
            this.userDashboard1.Size = new System.Drawing.Size(1075, 658);
            this.userDashboard1.TabIndex = 5;
            this.userDashboard1.Load += new System.EventHandler(this.userDashboard1_Load);
            // 
            // masterSiswa1
            // 
            this.masterSiswa1.BackColor = System.Drawing.Color.MintCream;
            this.masterSiswa1.Location = new System.Drawing.Point(-27, -12);
            this.masterSiswa1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.masterSiswa1.Name = "masterSiswa1";
            this.masterSiswa1.Size = new System.Drawing.Size(1728, 889);
            this.masterSiswa1.TabIndex = 4;
            // 
            // masterBuku1
            // 
            this.masterBuku1.Location = new System.Drawing.Point(-4, -6);
            this.masterBuku1.Margin = new System.Windows.Forms.Padding(4);
            this.masterBuku1.Name = "masterBuku1";
            this.masterBuku1.Size = new System.Drawing.Size(980, 699);
            this.masterBuku1.TabIndex = 6;
            this.masterBuku1.Load += new System.EventHandler(this.masterBuku1_Load);
            // 
            // peminjamanBuku1
            // 
            this.peminjamanBuku1.Location = new System.Drawing.Point(0, -15);
            this.peminjamanBuku1.Margin = new System.Windows.Forms.Padding(4);
            this.peminjamanBuku1.Name = "peminjamanBuku1";
            this.peminjamanBuku1.Size = new System.Drawing.Size(976, 703);
            this.peminjamanBuku1.TabIndex = 7;
            // 
            // pengembalianBuku1
            // 
            this.pengembalianBuku1.Location = new System.Drawing.Point(0, -29);
            this.pengembalianBuku1.Margin = new System.Windows.Forms.Padding(4);
            this.pengembalianBuku1.Name = "pengembalianBuku1";
            this.pengembalianBuku1.Size = new System.Drawing.Size(942, 696);
            this.pengembalianBuku1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1279, 767);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MasterSiswa masterSiswa1;
        private UserDashboard userDashboard1;
        private MasterBuku masterBuku1;
        private PengembalianBuku pengembalianBuku1;
        private PeminjamanBuku peminjamanBuku1;
    }
}