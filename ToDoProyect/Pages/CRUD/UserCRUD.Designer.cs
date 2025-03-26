namespace ToDoProyect.Pages.CRUD
{
    partial class UserCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trelloProyectDBDataSet = new ToDoProyect.TrelloProyectDBDataSet();
            this.departamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.userStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new ToDoProyect.TrelloProyectDBDataSetTableAdapters.departmentsTableAdapter();
            this.estadosTableAdapter = new ToDoProyect.TrelloProyectDBDataSetTableAdapters.userStatesTableAdapter();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttModify = new System.Windows.Forms.Button();
            this.bttViewData = new System.Windows.Forms.Button();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new ToDoProyect.TrelloProyectDBDataSetTableAdapters.usersTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.departamentosTableAdapter1 = new ToDoProyect.TrelloProyectDBDataSetTableAdapters.departmentsTableAdapter();
            this.estadosUserTableAdapter = new ToDoProyect.TrelloProyectDBDataSetTableAdapters.userStatesTableAdapter();
            this.bttBack = new System.Windows.Forms.Button();
            this.toDoProyectDataSet = new ToDoProyect.TrelloProyectDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trelloProyectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(144, 134);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(100, 20);
            this.txtApePat.TabIndex = 7;
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(144, 177);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(100, 20);
            this.txtApeMat.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(428, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(428, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DataSource = this.departmentsBindingSource;
            this.cmbDepartment.DisplayMember = "name";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(979, 97);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 11;
            this.cmbDepartment.ValueMember = "idDepartment";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.trelloProyectDBDataSet;
            this.departmentsBindingSource.Position = 0;
            // 
            // trelloProyectDBDataSet
            // 
            this.trelloProyectDBDataSet.DataSetName = "ToDoProyectDataSet1";
            this.trelloProyectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosBindingSource1
            // 
            this.departamentosBindingSource1.DataMember = "departments";
            this.departamentosBindingSource1.DataSource = this.trelloProyectDBDataSet;
            this.departamentosBindingSource1.Position = 0;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataSource = this.trelloProyectDBDataSet;
            this.departamentosBindingSource.Position = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(899, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(899, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado";
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DataSource = this.userStatesBindingSource;
            this.cmbEstatus.DisplayMember = "name";
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Location = new System.Drawing.Point(979, 142);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(121, 21);
            this.cmbEstatus.TabIndex = 13;
            this.cmbEstatus.ValueMember = "idState";
            // 
            // userStatesBindingSource
            // 
            this.userStatesBindingSource.DataMember = "userStates";
            this.userStatesBindingSource.DataSource = this.trelloProyectDBDataSet;
            this.userStatesBindingSource.Position = 0;
            // 
            // estadosUserBindingSource
            // 
            this.estadosUserBindingSource.DataMember = "userStates";
            this.estadosUserBindingSource.DataSource = this.trelloProyectDBDataSet;
            this.estadosUserBindingSource.Position = 0;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataSource = this.trelloProyectDBDataSet;
            this.estadosBindingSource.Position = 0;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // dataView
            // 
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(50, 248);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(1067, 150);
            this.dataView.TabIndex = 15;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(324, 193);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 16;
            this.bttAdd.Text = "Crear";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(590, 193);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 17;
            this.bttDelete.Text = "Dar de Baja";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttModify
            // 
            this.bttModify.Location = new System.Drawing.Point(454, 193);
            this.bttModify.Name = "bttModify";
            this.bttModify.Size = new System.Drawing.Size(75, 23);
            this.bttModify.TabIndex = 18;
            this.bttModify.Text = "Modificar";
            this.bttModify.UseVisualStyleBackColor = true;
            this.bttModify.Click += new System.EventHandler(this.bttModify_Click);
            // 
            // bttViewData
            // 
            this.bttViewData.Location = new System.Drawing.Point(1042, 210);
            this.bttViewData.Name = "bttViewData";
            this.bttViewData.Size = new System.Drawing.Size(75, 23);
            this.bttViewData.TabIndex = 19;
            this.bttViewData.Text = "Vizualizar";
            this.bttViewData.UseVisualStyleBackColor = true;
            this.bttViewData.Click += new System.EventHandler(this.bttViewData_Click);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = this.trelloProyectDBDataSet;
            this.usuariosBindingSource.Position = 0;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(299, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Id";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(715, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 25;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(715, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Contraseña";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Usuario";
            // 
            // departamentosTableAdapter1
            // 
            this.departamentosTableAdapter1.ClearBeforeFill = true;
            // 
            // estadosUserTableAdapter
            // 
            this.estadosUserTableAdapter.ClearBeforeFill = true;
            // 
            // bttBack
            // 
            this.bttBack.Location = new System.Drawing.Point(428, 39);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(75, 23);
            this.bttBack.TabIndex = 51;
            this.bttBack.Text = "Regresar";
            this.bttBack.UseVisualStyleBackColor = true;
            this.bttBack.Click += new System.EventHandler(this.bttBack_Click);
            // 
            // toDoProyectDataSet
            // 
            this.toDoProyectDataSet.DataSetName = "TrelloProyectDBDataSet";
            this.toDoProyectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.bttBack);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bttViewData);
            this.Controls.Add(this.bttModify);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserCRUD";
            this.Text = "UserCRUD";
            this.Load += new System.EventHandler(this.UserCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trelloProyectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private TrelloProyectDBDataSetTableAdapters.departmentsTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private TrelloProyectDBDataSetTableAdapters.userStatesTableAdapter estadosTableAdapter;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttModify;
        private System.Windows.Forms.Button bttViewData;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private TrelloProyectDBDataSetTableAdapters.usersTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private TrelloProyectDBDataSet trelloProyectDBDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource1;
        private TrelloProyectDBDataSetTableAdapters.departmentsTableAdapter departamentosTableAdapter1;
        private System.Windows.Forms.BindingSource estadosUserBindingSource;
        private TrelloProyectDBDataSetTableAdapters.userStatesTableAdapter estadosUserTableAdapter;
        private System.Windows.Forms.Button bttBack;
        private TrelloProyectDBDataSet toDoProyectDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private System.Windows.Forms.BindingSource userStatesBindingSource;
    }
}