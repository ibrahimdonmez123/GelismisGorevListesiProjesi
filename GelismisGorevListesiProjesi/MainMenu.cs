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

namespace GelismisGorevListesiProjesi
{
    public partial class MainMenu : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JI1JKUA\\SQLEXPRESS;Initial Catalog=NotDefter;Integrated Security=True");



        public MainMenu()
        {
            InitializeComponent();

            
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_click_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string content = txtContent.Text;

            conn.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO Notes (Title, Content) VALUES ('{title}', '{content}')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Not başarıyla kaydedildi.");
            txtTitle.Text = "";
            txtContent.Text = "";
            conn.Close();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            conn.Open();
            Form listForm = new Form();
            listForm.Size = new Size(300, 500);
            listForm.StartPosition = FormStartPosition.CenterScreen;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Notes", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            ListBox listBox = new ListBox();
            while (reader.Read())
            {
                listBox.Items.Add($"{reader["Title"]}: {reader["Content"]}");
            }

            listForm.Controls.Add(listBox);
            listForm.ShowDialog();
            reader.Close();
            conn.Close();

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
