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
    public partial class UserCRUD : Form
    {
        string con = Program.getConnectionString();
        public UserCRUD()
        {
            InitializeComponent();
        }

        private void Limpieza()
        {
            txtName.Text = string.Empty;
            txtApeMat.Text = string.Empty;
            txtApePat.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private bool _VerifyData()
        {
            string regexPhone = @"^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";
            string regexName = @"^[a-zA-Z]+$";

            bool validName = Regex.IsMatch(txtName.Text, regexName);
            bool validLastName = Regex.IsMatch(txtApePat.Text, regexName);
            bool validMiddleName = Regex.IsMatch(txtApeMat.Text, regexName);
            bool validPhone = Regex.IsMatch(txtPhone.Text, regexPhone);

            if (!validName || !validLastName || !validMiddleName)
            {
                MessageBox.Show("Invalid Name Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!validPhone)
            {
                MessageBox.Show("Invalid Phone Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool _VerifyMail()
        {
            string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool validEmail = Regex.IsMatch(txtEmail.Text, regexEmail);
            if (!validEmail)
            {
                MessageBox.Show("Invalid Email Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UserCRUD_Load(object sender, EventArgs e)
        {
            // Se cargan los datos en el DataSet con la nueva estructura:
            this.estadosUserTableAdapter.Fill(this.trelloProyectDBDataSet.userStates);
            this.departamentosTableAdapter.Fill(this.trelloProyectDBDataSet.departments);
        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(con))
            {
                // Se utiliza la vista usersView (asegúrate de haberla actualizado en la base de datos)
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM usersView", cn);
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
                    if (_VerifyMail())
                    {
                        // Inserción en la tabla users con las nuevas columnas en lowerCamelCase:
                        SqlCommand cmd = new SqlCommand($@"
                            INSERT INTO users(name, lastName, middleName, email, phone, username, password, idRole, idDepartment, idState)
                            VALUES ('{txtName.Text}', '{txtApePat.Text}', '{txtApeMat.Text}', '{txtEmail.Text}', '{txtPhone.Text}', '{txtUsername.Text}', '{txtPassword.Text}', 2, {cmbDepartment.SelectedIndex + 1}, {cmbEstatus.SelectedIndex + 1})
                        ", cn);
                        cmd.CommandType = CommandType.Text;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpieza();
                    }
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                // Se actualiza el estado del usuario a 2 (por ejemplo, "Inactive")
                SqlCommand cmd = new SqlCommand($@"
                    UPDATE users 
                    SET idState = 2 
                    WHERE idUser = {txtId.Text}
                ", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpieza();
            }
        }

        private void bttModify_Click(object sender, EventArgs e)
        {
            if (_VerifyData())
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    if (_VerifyMail())
                    {
                        // Actualiza los datos del usuario
                        SqlCommand cmd = new SqlCommand($@"
                            UPDATE users 
                            SET name = '{txtName.Text}', 
                                lastName = '{txtApePat.Text}', 
                                middleName = '{txtApeMat.Text}', 
                                email = '{txtEmail.Text}', 
                                phone = '{txtPhone.Text}', 
                                idRole = 2, 
                                idDepartment = {cmbDepartment.SelectedIndex + 1}, 
                                idState = {cmbEstatus.SelectedIndex + 1}
                            WHERE idUser = {txtId.Text}
                        ", cn);
                        cmd.CommandType = CommandType.Text;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpieza();
                    }
                }
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataView.Rows[e.RowIndex];
                // Se utilizan los alias definidos en la vista usersView:
                txtId.Text = row.Cells["ID"]?.Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["Name"]?.Value?.ToString() ?? string.Empty;
                txtApePat.Text = row.Cells["Last Name"]?.Value?.ToString() ?? string.Empty;
                txtApeMat.Text = row.Cells["Middle Name"]?.Value?.ToString() ?? string.Empty;
                txtEmail.Text = row.Cells["Email"]?.Value?.ToString() ?? string.Empty;
                txtPhone.Text = row.Cells["Phone"]?.Value?.ToString() ?? string.Empty;
                txtUsername.Text = row.Cells["Username"]?.Value?.ToString() ?? string.Empty;
                txtPassword.Text = row.Cells["Password"]?.Value?.ToString() ?? string.Empty;

                // Si la vista incluye el id del departamento y del estado como valores numéricos
                if (int.TryParse(row.Cells["Department"]?.Value?.ToString(), out int deptId))
                {
                    cmbDepartment.SelectedIndex = deptId - 1;
                }
                if (int.TryParse(row.Cells["State"]?.Value?.ToString(), out int statusId))
                {
                    cmbEstatus.SelectedIndex = statusId - 1;
                }
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
