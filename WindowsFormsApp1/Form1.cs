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
    public partial class Form1 : Form
    {
        DBConnection con = new DBConnection();
        MySqlCommand command;
        MySqlCommand command2;
        MySqlDataAdapter da;
        MySqlDataAdapter da2;
        //DataTable dt;

        string id, name, surname, client_id, pin, stan;

        public Form1()
        {
            InitializeComponent();
            con.Connect();
        }
        private void signIn_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * FROM klienci WHERE id_klienta='"+inputId.Text +"' AND pin = '"+inputPin.Text+"'", con.cn);
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
                        stan = reader["stan_konta"].ToString();
                        Program.globalid = Convert.ToInt32(client_id);
                        if (inputId.Text == client_id && inputPin.Text == pin)
                        {
                            MessageBox.Show("Pomyślnie zalogowano");
                            MessageBox.Show("Twoje dane: Imie: " + name + " ,Nazwisko: " + surname + " ,Stan Konta: " + stan);
                            inputId.Text = "";
                            inputPin.Text = "";
                            Form2 form2 = new Form2();
                            form2.Show();

                        }
                        else
                        {
                            MessageBox.Show("Błędne dane logowania");
                        }
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
    }
}
