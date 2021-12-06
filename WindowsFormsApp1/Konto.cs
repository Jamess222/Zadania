using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Konto : Form
    {
        DBConnection con = new DBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;



        string id, name, surname, client_id, pin;

        public Konto()
        {
            InitializeComponent();
            con.Connect();
        }

        private void Konto_Load(object sender, EventArgs e)
        {
            int mainid = Program.globalid;
            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select id, id_klienta, imie, nazwisko, pin FROM klienci WHERE id_klienta='"+mainid+"'", con.cn);
                command.ExecuteNonQuery();
                MySqlDataReader reader = command.ExecuteReader();
                //dt = new DataTable();
                da = new MySqlDataAdapter(command);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader["id"].ToString();
                        name = reader["imie"].ToString();
                        surname = reader["nazwisko"].ToString();
                        client_id = reader["id_klienta"].ToString();
                        pin = reader["pin"].ToString();

                        MessageBox.Show("Witaj " + name + "!");
                    }
                    //MessageBox.Show("properly read" + name + " " + pin + " " + client_id);
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                //da.Fill(dt);
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * FROM klienci", con.cn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                con.cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
