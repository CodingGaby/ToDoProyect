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
    public partial class UserPage : Form
    {
        string con = Program.getConnectionString();

        public UserPage(string v)
        {
            InitializeComponent();
            lblUser.Text = v;
        }

        private void CleanInputs()
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
            // Expresión regular para el formato dd/MM/yyyy
            string regexDate = @"^\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/([0-9]{4})\b$";

            bool validDateIn = Regex.IsMatch(txtDateIn.Text, regexDate);
            bool validDateLast = Regex.IsMatch(txtDateLast.Text, regexDate);

            if (!validDateIn || !validDateLast)
            {
                MessageBox.Show("Formato de Fecha Erróneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataView.Rows[e.RowIndex];

                // Verificar si las celdas no son null antes de asignar
                txtId.Text = row.Cells["ID"]?.Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["Nombre de la Actividad"]?.Value?.ToString() ?? string.Empty;
                txtDateIn.Text = row.Cells["Fecha ingreso"]?.Value?.ToString() ?? string.Empty;
                txtDateLast.Text = row.Cells["Fecha entrega"]?.Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["Descripcion"]?.Value?.ToString() ?? string.Empty;
                txtUrl.Text = row.Cells["URL del Documento"]?.Value?.ToString() ?? string.Empty;
                txtProject.Text = row.Cells["Nombre del Proyecto"]?.Value?.ToString() ?? string.Empty;
                txtStatus.Text = row.Cells["Estado"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(con))
            {
                // Consulta adaptada a la nueva estructura de tablas y columnas
                SqlDataAdapter da = new SqlDataAdapter($@"
                    SELECT 
                        a.idActivity       AS 'ID', 
                        a.name             AS 'Nombre de la Actividad', 
                        a.startDate        AS 'Fecha ingreso', 
                        a.deliveryDate     AS 'Fecha entrega', 
                        a.description      AS 'Descripcion', 
                        a.urlDocument      AS 'URL del Documento', 
                        p.idProject        AS 'ID Proyecto', 
                        p.name             AS 'Nombre del Proyecto', 
                        e.name             AS 'Estado'
                    FROM activities a
                    JOIN activityStates e ON a.idState = e.idState
                    JOIN projects p      ON a.idProject = p.idProject
                    JOIN users u         ON a.idUser = u.idUser
                    WHERE u.username = '{lblUser.Text}'
                ", cn);

                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);
                dataView.DataSource = dt;
            }
        }

        private void bttComplete_Click(object sender, EventArgs e)
        {
            if (_VerifyData())
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    // Cambiamos la actividad a estado 3 (Finalizado) y actualizamos la fecha de entrega
                    SqlCommand cmd = new SqlCommand($@"
                        UPDATE activities
                        SET deliveryDate = '{txtDateLast.Text}', 
                            idState = 3
                        WHERE idActivity = {txtId.Text}
                    ", cn);

                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanInputs();
                }
            }
        }

        private void bttWaiting_Click(object sender, EventArgs e)
        {
            if (_VerifyData())
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    // Cambiamos la actividad a estado 2 (En Espera) y actualizamos la fecha de entrega
                    SqlCommand cmd = new SqlCommand($@"
                        UPDATE activities
                        SET deliveryDate = '{txtDateLast.Text}', 
                            idState = 2
                        WHERE idActivity = {txtId.Text}
                    ", cn);

                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanInputs();
                }
            }
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            Hide();
            new MainPage().Show();
        }
    }
}
