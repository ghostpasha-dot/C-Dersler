using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Data Source=DESKTOP-KR3A2BP\SQLEXPRESS;Initial Catalog=okul;User ID=serhat;Password=159357258";
                SqlCommand komut = new SqlCommand("select okul_adi from okul",baglanti);
                komut.CommandText = "SELECT * FROM okullar";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add((dr[1].ToString()));
                }
                baglanti.Close();
        }
    }
}
