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
using System.Xml.Linq;

namespace ToDoProyect.Pages.CRUD
{
    public partial class ProjectCRUD: Form
    {
        string con = "Data Source=LAPTOP-P6SV6G8N;Initial Catalog=ToDoProyect;Integrated Security=True;Encrypt=False";
        public ProjectCRUD()
        {
            InitializeComponent();
        }
        private void Limpieza()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDateIn.Text = string.Empty;
            txtDateLast.Text = string.Empty;
            txtDescription.Text = string.Empty;
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


        private void ProjectCRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'toDoProyectDataSet1.EstadosProyectos' Puede moverla o quitarla según sea necesario.
            this.estadosProyectosTableAdapter.Fill(this.toDoProyectDataSet1.EstadosProyectos);

        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using ( SqlConnection cn = new SqlConnection(con) )
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM ProyectsViews", cn);

                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();

                da.Fill(dt);

                dataView.DataSource = dt;
            }
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            string a = "";
            Hide();
            new AdminPage(a).Show();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if ( _VerifyData() )
            {

                using ( SqlConnection cn = new SqlConnection(con) )
                {

                    SqlCommand cmd = new SqlCommand($"INSERT INTO Proyectos(Nombre, FechaIn, FechaEntrega, descripcion, Id_Estado) VALUES ('{txtName.Text}','{txtDateIn.Text}','{txtDateLast.Text}','{txtDescription.Text}', {cmbEstatus.SelectedIndex + 1})", cn);
                    cmd.CommandType = CommandType.Text; // Codigo Miss - cmd.CommandType cn = CommandType.Text;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpieza();
                    
                }
            }
        }

        private void bttModify_Click(object sender, EventArgs e)
        {
            if ( _VerifyData() )
            {

                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    //if ( _VerifyMail() )
                    //{
                        SqlCommand cmd = new SqlCommand($"Update Proyectos set Nombre = '{txtName.Text}', FechaIn = '{txtDateIn.Text}', FechaEntrega = '{txtDateLast.Text}', descripcion = '{txtDescription.Text}', Id_Estado = {( cmbEstatus.SelectedIndex + 1 )} WHERE Id_Proyecto = {txtId.Text}", cn);

                        cmd.CommandType = CommandType.Text;

                        cn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpieza();
                    //}
                }
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0 )
            {
                var row = dataView.Rows[ e.RowIndex ];

                // Verificar si las celdas no son null antes de asignar
                txtId.Text = row.Cells[ "ID" ]?.Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells[ "Nombre del Proyecto" ]?.Value?.ToString() ?? string.Empty;
                txtDateIn.Text = row.Cells[ "Fecha ingreso" ]?.Value?.ToString() ?? string.Empty;
                txtDateLast.Text = row.Cells[ "Fecha entrega" ]?.Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells[ "Descripcion" ]?.Value?.ToString() ?? string.Empty;

                if ( int.TryParse(row.Cells[ "Estado" ]?.Value?.ToString(), out int statusId) )
                {
                    cmbEstatus.SelectedIndex = statusId - 1;
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            using ( SqlConnection cn = new SqlConnection(con) )
            {
                SqlCommand cmd = new SqlCommand($"Update Proyectos set Id_Estado = 4 WHERE Id_Proyecto = {txtId.Text}", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpieza();
            }
        }
    }
}
