using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desain_Rahma
{
    public partial class Form1 : Form
    {
        public SqlConnection conntection = new SqlConnection(koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conntection.Open();

            string username = tUsername.Text;
            string password = tPassword.Text;

            string sql = "SELECT * FROM [user] WHERE username = '" + tUsername.Text + "' AND password = '" + tPassword.Text + "'";
            command = new SqlCommand(sql, conntection);
            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                foreach (DataRow dr in tabel.Rows)
                {
                    if (dr["role"].ToString() == "admin")
                    { 
                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

                        this.Hide();
                        Form2 panggil = new Form2();
                        panggil.Show();
                    }
                    else if (dr["role"].ToString() == "siswa")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

                        this.Hide();
                        Form7 panggil = new Form7();
                        panggil.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

            conntection.Close();
            

            //Form2 panggil = new Form2();
            //panggil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void tUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
