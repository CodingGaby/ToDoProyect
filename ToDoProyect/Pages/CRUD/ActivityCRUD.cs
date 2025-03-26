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

namespace ToDoProyect.Pages.CRUD
{
    public partial class ActivityCRUD: Form
    {
        string con = "Data Source=LAPTOP-P6SV6G8N;Initial Catalog=ToDoProyect;Integrated Security=True;Encrypt=False";

        public ActivityCRUD()
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
            txtUrl.Text = string.Empty;
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

        private void ActivityCRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'toDoProyectDataSet3.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter2.Fill(this.toDoProyectDataSet3.Proyectos);
            // TODO: esta línea de código carga datos en la tabla 'toDoProyectDataSet1.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter1.Fill(this.toDoProyectDataSet1.Proyectos);
            // TODO: esta línea de código carga datos en la tabla 'toDoProyectDataSet2.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.toDoProyectDataSet2.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'toDoProyectDataSet2.EstadoActividades' Puede moverla o quitarla según sea necesario.
            this.estadoActividadesTableAdapter.Fill(this.toDoProyectDataSet2.EstadoActividades);

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

                if ( int.TryParse(row.Cells[ "Estado" ]?.Value?.ToString(), out int statusId) )
                {
                    cmbEstatus.SelectedIndex = statusId - 1;
                }
            }
        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(cmbProject.SelectedIndex + 1);

            DataTable dt = new DataTable();

            using ( SqlConnection cn = new SqlConnection(con) )
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM ActividadesView", cn);

                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();

                da.Fill(dt);

                dataView.DataSource = dt;
            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if ( _VerifyData() )
            {

                using ( SqlConnection cn = new SqlConnection(con) )
                {

                    SqlCommand cmd = new SqlCommand($"INSERT INTO Actividades(Nombre, FechaIn, FechaEntrega, descripcion, URLDocument, Id_Proyecto, Id_User, Id_Estado) VALUES ('{txtName.Text}','{txtDateIn.Text}','{txtDateLast.Text}','{txtDescription.Text}', '{txtUrl.Text}', {cmbProject.SelectedIndex + 1}, {cmbUser.SelectedIndex + 1}, {cmbEstatus.SelectedIndex + 1})", cn);
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
                    SqlCommand cmd = new SqlCommand($"Update Actividades set Nombre = '{txtName.Text}', FechaIn = '{txtDateIn.Text}', FechaEntrega = '{txtDateLast.Text}', descripcion = '{txtDescription.Text}', URLDocument = '{txtUrl.Text}', Id_Proyecto = {cmbProject.SelectedIndex + 1}, Id_User = {cmbUser.SelectedIndex + 1}, Id_Estado = {( cmbEstatus.SelectedIndex + 1 )} WHERE Id_Actividad = {txtId.Text}", cn);

                    cmd.CommandType = CommandType.Text;

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpieza();
                    //}
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            using ( SqlConnection cn = new SqlConnection(con) )
            {
                SqlCommand cmd = new SqlCommand($"Update Actividades set Id_Estado = 4 WHERE Id_Actividad = {txtId.Text}", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpieza();
            }
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            string a = "";
            Hide();
            new AdminPage(a).Show();
        }
    }
}
