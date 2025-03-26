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
    public partial class UserCRUD: Form
    {

        string con = "Data Source=LAPTOP-P6SV6G8N;Initial Catalog=ToDoProyect;Integrated Security=True;Encrypt=False";
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

            bool ValidName = Regex.IsMatch(txtName.Text, regexName);
            bool ValidAP = Regex.IsMatch(txtApePat.Text, regexName);
            bool ValidAM = Regex.IsMatch(txtApeMat.Text, regexName);
            bool ValidPhone = Regex.IsMatch(txtPhone.Text, regexPhone);

            if ( !ValidName || !ValidAP || !ValidAM )
            {
                MessageBox.Show("Formato de Nombre Erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if ( !ValidPhone )
            {
                MessageBox.Show("Formato de Telefono Erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool _VerifyMail()
        {

            string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            bool ValidEmail = Regex.IsMatch(txtEmail.Text, regexEmail);

            if ( !ValidEmail )
            {
                MessageBox.Show("Formato de Correo Erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void UserCRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'toDoProyectDataSet1.EstadosUser' Puede moverla o quitarla según sea necesario.
            this.estadosUserTableAdapter.Fill(this.toDoProyectDataSet1.EstadosUser);
            // TODO: esta línea de código carga datos en la tabla 'toDoProyectDataSet1.Departamentos' Puede moverla o quitarla según sea necesario.
            this.departamentosTableAdapter1.Fill(this.toDoProyectDataSet1.Departamentos);

        }

        private void bttViewData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM UsuariosView", cn);

                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();

                da.Fill(dt);

                dataView.DataSource = dt;
            }
        }

        

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if ( _VerifyData()) {

                using ( SqlConnection cn = new SqlConnection(con) )
                {

                    if ( _VerifyMail() )
                    {

                        SqlCommand cmd = new SqlCommand($"INSERT INTO Usuarios(Nombre, ApePat, ApeMat, Correo, Telefono, NomUsuario, Contra, Id_Rol, Id_Departamento, Id_Estado) VALUES ('{txtName.Text}','{txtApePat.Text}','{txtApeMat.Text}','{txtEmail.Text}','{txtPhone.Text}','{txtUsername.Text}','{txtPassword.Text}', 2, {cmbDepartment.SelectedIndex + 1}, {cmbEstatus.SelectedIndex + 1})", cn);
                        cmd.CommandType = CommandType.Text; // Codigo Miss - cmd.CommandType cn = CommandType.Text;

                        cn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpieza();
                    }
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            using ( SqlConnection cn = new SqlConnection(con) )
            {
                SqlCommand cmd = new SqlCommand($"Update Usuarios set Id_Estado = 2 WHERE Id_User = {txtId.Text}", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Limpieza();   
            }
        }

        private void bttModify_Click(object sender, EventArgs e)
        {
            if ( _VerifyData() )
            {

                using ( SqlConnection cn = new SqlConnection(con) )
                {
                    if ( _VerifyMail() )
                    {
                        SqlCommand cmd = new SqlCommand($"Update Usuarios set Nombre = '{txtName.Text}', ApePat = '{txtApePat.Text}', ApeMat = '{txtApeMat.Text}', Correo = '{txtEmail.Text}', Telefono = '{txtPhone.Text}', Id_Rol = 2 , Id_Departamento = {( cmbDepartment.SelectedIndex + 1 )}, Id_Estado = {( cmbEstatus.SelectedIndex + 1 )} WHERE Id_User = {txtId.Text}", cn);

                        cmd.CommandType = CommandType.Text;

                        cn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ejecutado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpieza();
                    }
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
                txtName.Text = row.Cells[ "Nombre" ]?.Value?.ToString() ?? string.Empty;
                txtApePat.Text = row.Cells[ "Apellido Paterno" ]?.Value?.ToString() ?? string.Empty;
                txtApeMat.Text = row.Cells[ "Apellido Materno" ]?.Value?.ToString() ?? string.Empty;
                txtEmail.Text = row.Cells[ "Correo" ]?.Value?.ToString() ?? string.Empty;
                txtPhone.Text = row.Cells[ "Telefono" ]?.Value?.ToString() ?? string.Empty;
                txtUsername.Text = row.Cells[ "Nombre de Usuario" ]?.Value?.ToString() ?? string.Empty;
                txtPassword.Text = row.Cells[ "Contraseña" ]?.Value?.ToString() ?? string.Empty;

                // Verificar ComboBox para evitar errores
                if ( int.TryParse(row.Cells[ "Departamento" ]?.Value?.ToString(), out int deptId) )
                {
                    cmbDepartment.SelectedIndex = deptId - 1;
                }

                if ( int.TryParse(row.Cells[ "Estado" ]?.Value?.ToString(), out int statusId) )
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
