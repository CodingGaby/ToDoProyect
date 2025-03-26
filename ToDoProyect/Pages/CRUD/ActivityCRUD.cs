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
    public partial class ActivityCRUD : Form
    {
        string con = Program.getConnectionString();
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

        private void ActivityCRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trelloProyectDBDataSet.projectsView' Puede moverla o quitarla según sea necesario.
            this.projectsViewTableAdapter.Fill(this.trelloProyectDBDataSet.projectsView);
            // Estas líneas cargan los datos en los DataSet. Asegúrate de que estén configurados
            // para la nueva estructura de tablas y vistas (activities, projects, activityStates, users, activitiesView)
            this.activitiesViewTableAdapter.Fill(this.trelloProyectDBDataSet.activitiesView);
            this.usersTableAdapter.Fill(this.trelloProyectDBDataSet.users);
            this.activityStatesTableAdapter.Fill(this.trelloProyectDBDataSet.activityStates);
            this.projectsTableAdapter.Fill(this.trelloProyectDBDataSet.projects);
            this.activitiesTableAdapter.Fill(this.trelloProyectDBDataSet.activities);
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataView.Rows[e.RowIndex];

                // Se usan los alias definidos en la vista activitiesView:
                txtId.Text = row.Cells["iDDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["activityNameDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                txtDateIn.Text = row.Cells["startDateDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                txtDateLast.Text = row.Cells["deliveryDateDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["descriptionDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                txtUrl.Text = row.Cells["documentURLDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                cmbEstatus.Text = row.Cells["stateDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                cmbProject.Text = row.Cells["projectNameDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                cmbUser.Text = row.Cells["userNameDataGridViewTextBoxColumn"]?.Value?.ToString() ?? string.Empty;
                Console.WriteLine(row.Cells["projectIDDataGridViewTextBoxColumn"]?.Value);
                Console.WriteLine(row.Cells["projectIDDataGridViewTextBoxColumn"]?.Value?.GetType());
            }
        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(con))
            {
                // Se actualiza la consulta para usar la vista activitiesView
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM activitiesView", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);
                dataView.DataSource = dt;
            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (_VerifyData())
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    // Inserta en la tabla activities usando la nueva estructura
                    SqlCommand cmd = new SqlCommand($@"
                        INSERT INTO activities(name, startDate, deliveryDate, description, urlDocument, idProject, idUser, idState)
                        VALUES ('{txtName.Text}', '{txtDateIn.Text}', '{txtDateLast.Text}', '{txtDescription.Text}', '{txtUrl.Text}', 
                                {cmbProject.SelectedIndex + 1}, {cmbUser.SelectedIndex + 1}, {cmbEstatus.SelectedIndex + 1})
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
                    // Actualiza la actividad en la tabla activities
                    SqlCommand cmd = new SqlCommand($@"
                        UPDATE activities 
                        SET name = '{txtName.Text}', 
                            startDate = '{txtDateIn.Text}', 
                            deliveryDate = '{txtDateLast.Text}', 
                            description = '{txtDescription.Text}', 
                            urlDocument = '{txtUrl.Text}', 
                            idProject = {cmbProject.SelectedIndex + 1}, 
                            idUser = {cmbUser.SelectedIndex + 1}, 
                            idState = {cmbEstatus.SelectedIndex + 1} 
                        WHERE idActivity = {txtId.Text}
                    ", cn);

                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ejecutado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpieza();
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                // Marca la actividad como eliminada (estado 4) en la tabla activities
                SqlCommand cmd = new SqlCommand($@"
                    UPDATE activities 
                    SET idState = 4 
                    WHERE idActivity = {txtId.Text}
                ", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ejecutado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpieza();
            }
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            Hide();
            new AdminPage(string.Empty).Show();
        }
    }
}
