using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoProyect
{

    public partial class UserPage: Form
    {
        string con = "Data Source=LAPTOP-P6SV6G8N;Initial Catalog=ToDoProyect;Integrated Security=True;Encrypt=False";

        public UserPage(string v)
        {
            InitializeComponent();
            lblUser.Text = v;
        }
        private void Limpieza()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDateIn.Text = string.Empty;
            txtDateLast.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtUrl.Text = string.Empty;
            txtProject.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private bool _VerifyData()
        {
            string regexDate = @"^\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/([0-9]{4})\b$";

            bool ValidDateIn = Regex.IsMatch(txtDateIn.Text, regexDate);
            bool ValidDateLast = Regex.IsMatch(txtDateLast.Text, regexDate);

            if ( !ValidDateIn || !ValidDateIn )
            {
                MessageBox.Show("Formato de Fecha Erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0 )
            {
                var row = dataView.Rows[ e.RowIndex ];

                // Verificar si las celdas no son null antes de asignar
                txtId.Text = row.Cells[ "ID" ]?.Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells[ "Nombre de la Actividad" ]?.Value?.ToString() ?? string.Empty;
                txtDateIn.Text = row.Cells[ "Fecha ingreso" ]?.Value?.ToString() ?? string.Empty;
                txtDateLast.Text = row.Cells[ "Fecha entrega" ]?.Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells[ "Descripcion" ]?.Value?.ToString() ?? string.Empty;
                txtUrl.Text = row.Cells[ "URL del Documento" ]?.Value?.ToString() ?? string.Empty;
                txtProject.Text = row.Cells[ "Nombre del Proyecto" ]?.Value?.ToString() ?? string.Empty;
                txtStatus.Text = row.Cells[ "Estado" ]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using ( SqlConnection cn = new SqlConnection(con) )
            {
                SqlDataAdapter da = new SqlDataAdapter($"Select a.Id_Actividad as 'ID', a.Nombre as 'Nombre de la Actividad', a.FechaIn as 'Fecha Ingreso', a.FechaEntrega as 'Fecha Entrega', a.descripcion as 'Descripcion', a.URLDocument as 'URL del Documento', p.Id_Proyecto as 'ID Proyecto', p.Nombre as 'Nombre del Proyecto', e.Nombre as 'Estado' from Actividades a, EstadoActividades e, Proyectos p, Usuarios u where a.Id_Estado = e.Id_Estado AND a.Id_User = u.Id_User AND u.NomUsuario = '{lblUser.Text}' AND a.Id_Proyecto = p.Id_Proyecto", cn);

                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();

                da.Fill(dt);

                dataView.DataSource = dt;
            }
        }

        private void bttComplete_Click(object sender, EventArgs e)
        {
            if ( _VerifyData() )
            {

                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    //if ( _VerifyMail() )
                    //{
                    SqlCommand cmd = new SqlCommand($"Update Actividades set FechaEntrega = '{txtDateLast.Text}', Id_Estado = 3 WHERE Id_Actividad = {txtId.Text}", cn);

                    cmd.CommandType = CommandType.Text;

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpieza();
                    //}
                }
            }
        }

        private void bttWaiting_Click(object sender, EventArgs e)
        {
            if ( _VerifyData() )
            {

                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    //if ( _VerifyMail() )
                    //{
                    SqlCommand cmd = new SqlCommand($"Update Actividades set FechaEntrega = '{txtDateLast.Text}', Id_Estado = 2 WHERE Id_Actividad = {txtId.Text}", cn);

                    cmd.CommandType = CommandType.Text;

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpieza();
                    //}
                }
            }
        }

        private void bttURL_Click(object sender, EventArgs e)
        {
            using ( SqlConnection cn = new SqlConnection(con) )
            {
                //if ( _VerifyMail() )
                //{
                SqlCommand cmd = new SqlCommand($"Update Actividades set URLDocument = '{txtUrl.Text}' WHERE Id_Actividad = {txtId.Text}", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpieza();
                //}
            }
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            Hide();
            new MainPage().Show();
        }
    }
}
