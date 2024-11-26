using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desain_Rahma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label6.Text = Model.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            masterSiswa1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            masterBuku1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            peminjamanBuku1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pengembalianBuku1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void masterBuku1_Load(object sender, EventArgs e)
        {

        }

        private void userDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
