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
    public partial class ProjectCRUD : Form
    {
        string con = Program.getConnectionString();
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

        private void ProjectCRUD_Load(object sender, EventArgs e)
        {
            // Se carga la información de projectStates desde el DataSet configurado
            this.estadosProyectosTableAdapter.Fill(this.trelloProyectDBDataSet.projectStates);
        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(con))
            {
                // Se utiliza la vista projectsView
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM projectsView", cn);
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
            if (_VerifyData())
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    // Inserta en la tabla projects usando los nuevos nombres de columnas
                    SqlCommand cmd = new SqlCommand($@"
                        INSERT INTO projects(name, startDate, deliveryDate, description, idState)
                        VALUES ('{txtName.Text}','{txtDateIn.Text}','{txtDateLast.Text}','{txtDescription.Text}', {cmbEstatus.SelectedIndex + 1})
                    ", cn);
                    cmd.CommandType = CommandType.Text;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpieza();
                }
            }
        }

        private void bttModify_Click(object sender, EventArgs e)
        {
            if (_VerifyData())
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    // Actualiza la información en la tabla projects
                    SqlCommand cmd = new SqlCommand($@"
                        UPDATE projects 
                        SET name = '{txtName.Text}', 
                            startDate = '{txtDateIn.Text}', 
                            deliveryDate = '{txtDateLast.Text}', 
                            description = '{txtDescription.Text}', 
                            idState = {cmbEstatus.SelectedIndex + 1} 
                        WHERE idProject = {txtId.Text}
                    ", cn);

                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpieza();
                }
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataView.Rows[e.RowIndex];

                // Se utilizan los alias de la vista projectsView:
                txtId.Text = row.Cells["ID"]?.Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["Project Name"]?.Value?.ToString() ?? string.Empty;
                txtDateIn.Text = row.Cells["Start Date"]?.Value?.ToString() ?? string.Empty;
                txtDateLast.Text = row.Cells["Delivery Date"]?.Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["Description"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                // Se actualiza la actividad para marcarla como eliminada (estado 4)
                SqlCommand cmd = new SqlCommand($@"
                    UPDATE projects 
                    SET idState = 4 
                    WHERE idProject = {txtId.Text}
                ", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ejecutado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpieza();
            }
        }
    }
}
