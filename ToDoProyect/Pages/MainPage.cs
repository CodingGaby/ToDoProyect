﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoProyect.Pages;

namespace ToDoProyect
{
    public partial class MainPage: Form
    {
        SqlConnection conx = new SqlConnection(Program.getConnectionString());
        public MainPage()
        {
            InitializeComponent();
        }

        private void bttLogIn_Click(object sender, EventArgs e)
        {
            ValidarUsuario(txtUser.Text, txtPassword.Text);
        }

        private void ValidarUsuario(string user, string passw)
        {
            try
            {
                conx.Open();

                SqlCommand consult = new SqlCommand($"SELECT username, idRole FROM users Where username = '{user}' and password = '{passw}'", conx);

                SqlDataAdapter sd = new SqlDataAdapter(consult);

                DataTable dt = new DataTable();

                sd.Fill(dt);

                // Mesages para verificar
                //MessageBox.Show(sd.Fill(dt).ToString() + usuario + passw);

                //Console.WriteLine(sd.Fill(dt).ToString());

                if ( dt.Rows.Count == 1 )
                {
                    //this.Hide();
                    String cad = dt.Rows[ 0 ][ 1 ].ToString();
                    if ( cad == "1" )
                    {
                        Console.WriteLine(dt.Rows[ 0 ][ 1 ].ToString());
                        AdminPage admin = new AdminPage(dt.Rows[ 0 ][ 0 ].ToString());
                        admin.Show();
                        this.Hide();
                    }
                    else if ( dt.Rows[ 0 ][ 1 ].ToString() == "2" )
                    {
                        new UserPage(dt.Rows[ 0 ][ 0 ].ToString()).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
            }
            catch ( Exception e )
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conx.Close();
            }
        }
    }
}
