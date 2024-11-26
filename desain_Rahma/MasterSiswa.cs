using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desain_Rahma
{
    public partial class MasterSiswa : UserControl
    {

        public SqlConnection connection = new SqlConnection(koneksi.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public string unselectedLabel = "Pilih--";
        public MasterSiswa()
        {
            InitializeComponent();

            kelas.Text = unselectedLabel;
            showData();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "SELECT * from [siswa] " +
                    "INNER JOIN [user] ON [siswa].id_user = [user].id_user";

                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;

                dataGridView1.Columns[0].Visible = false; // id_siswa
                dataGridView1.Columns[1].Visible = false; // id_user
                dataGridView1.Columns[2].HeaderText = "NIS"; // nis
                dataGridView1.Columns[3].HeaderText = "Kelas"; // kelas
                dataGridView1.Columns[4].HeaderText = "Alamat"; // alamat
                dataGridView1.Columns[5].Visible = false; // id_user
                dataGridView1.Columns[6].HeaderText = "Nama Siswa"; // nama
                dataGridView1.Columns[7].Visible = false; // role
                dataGridView1.Columns[8].HeaderText = "Email"; // email
                dataGridView1.Columns[9].HeaderText = "Nomor Telepon"; // no_telp
                dataGridView1.Columns[10].HeaderText = "Username"; // username
                dataGridView1.Columns[11].HeaderText = "Password"; // password

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MasterSiswa_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
