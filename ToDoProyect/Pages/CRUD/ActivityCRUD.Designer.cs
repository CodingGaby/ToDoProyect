namespace ToDoProyect.Pages.CRUD
{
    partial class ActivityCRUD
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttBack = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bttViewData = new System.Windows.Forms.Button();
            this.bttModify = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.estadoActividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoProyectDataSet2 = new ToDoProyect.ToDoProyectDataSet2();
            this.txtDateLast = new System.Windows.Forms.TextBox();
            this.txtDateIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter = new ToDoProyect.ToDoProyectDataSet2TableAdapters.ProyectosTableAdapter();
            this.estadoActividadesTableAdapter = new ToDoProyect.ToDoProyectDataSet2TableAdapters.EstadoActividadesTableAdapter();
            this.usuariosTableAdapter = new ToDoProyect.ToDoProyectDataSet2TableAdapters.UsuariosTableAdapter();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.proyectosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toDoProyectDataSet1 = new ToDoProyect.ToDoProyectDataSet1();
            this.proyectosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter1 = new ToDoProyect.ToDoProyectDataSet1TableAdapters.ProyectosTableAdapter();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.proyectosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.toDoProyectDataSet3 = new ToDoProyect.ToDoProyectDataSet3();
            this.proyectosTableAdapter2 = new ToDoProyect.ToDoProyectDataSet3TableAdapters.ProyectosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(314, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Nombre de la Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(196, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "*Date format - dd/mm/yyyy";
            // 
            // bttBack
            // 
            this.bttBack.Location = new System.Drawing.Point(588, 50);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(75, 23);
            this.bttBack.TabIndex = 70;
            this.bttBack.Text = "Regresar";
            this.bttBack.UseVisualStyleBackColor = true;
            this.bttBack.Click += new System.EventHandler(this.bttBack_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(800, 108);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(354, 71);
            this.txtDescription.TabIndex = 69;
            this.txtDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(714, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Descripcion";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(459, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Id";
            // 
            // bttViewData
            // 
            this.bttViewData.Location = new System.Drawing.Point(1158, 245);
            this.bttViewData.Name = "bttViewData";
            this.bttViewData.Size = new System.Drawing.Size(75, 23);
            this.bttViewData.TabIndex = 65;
            this.bttViewData.Text = "Vizualizar";
            this.bttViewData.UseVisualStyleBackColor = true;
            this.bttViewData.Click += new System.EventHandler(this.bttViewData_Click);
            // 
            // bttModify
            // 
            this.bttModify.Location = new System.Drawing.Point(581, 235);
            this.bttModify.Name = "bttModify";
            this.bttModify.Size = new System.Drawing.Size(75, 23);
            this.bttModify.TabIndex = 64;
            this.bttModify.Text = "Modificar";
            this.bttModify.UseVisualStyleBackColor = true;
            this.bttModify.Click += new System.EventHandler(this.bttModify_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(717, 235);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 63;
            this.bttDelete.Text = "Dar de Baja";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(451, 235);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 62;
            this.bttAdd.Text = "Crear";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(122, 274);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(1111, 150);
            this.dataView.TabIndex = 61;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Estado";
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DataSource = this.estadoActividadesBindingSource;
            this.cmbEstatus.DisplayMember = "Nombre";
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Location = new System.Drawing.Point(521, 148);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(121, 21);
            this.cmbEstatus.TabIndex = 59;
            this.cmbEstatus.ValueMember = "Id_Estado";
            // 
            // estadoActividadesBindingSource
            // 
            this.estadoActividadesBindingSource.DataMember = "EstadoActividades";
            this.estadoActividadesBindingSource.DataSource = this.toDoProyectDataSet2;
            // 
            // toDoProyectDataSet2
            // 
            this.toDoProyectDataSet2.DataSetName = "ToDoProyectDataSet2";
            this.toDoProyectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDateLast
            // 
            this.txtDateLast.Location = new System.Drawing.Point(314, 185);
            this.txtDateLast.Name = "txtDateLast";
            this.txtDateLast.Size = new System.Drawing.Size(100, 20);
            this.txtDateLast.TabIndex = 58;
            // 
            // txtDateIn
            // 
            this.txtDateIn.Location = new System.Drawing.Point(314, 148);
            this.txtDateIn.Name = "txtDateIn";
            this.txtDateIn.Size = new System.Drawing.Size(100, 20);
            this.txtDateIn.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha Entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Fecha Ingresado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 54;
            this.label1.Text = "CRUD Actividades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Proyecto";
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "Proyectos";
            this.proyectosBindingSource.DataSource = this.toDoProyectDataSet2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Asignado";
            // 
            // cmbUser
            // 
            this.cmbUser.DataSource = this.usuariosBindingSource;
            this.cmbUser.DisplayMember = "Id_User";
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(521, 185);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 76;
            this.cmbUser.ValueMember = "Id_User";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.toDoProyectDataSet2;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // estadoActividadesTableAdapter
            // 
            this.estadoActividadesTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(800, 185);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(354, 20);
            this.txtUrl.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(700, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "URL Documento";
            // 
            // proyectosBindingSource1
            // 
            this.proyectosBindingSource1.DataMember = "Proyectos";
            this.proyectosBindingSource1.DataSource = this.toDoProyectDataSet2;
            // 
            // toDoProyectDataSet1
            // 
            this.toDoProyectDataSet1.DataSetName = "ToDoProyectDataSet1";
            this.toDoProyectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectosBindingSource2
            // 
            this.proyectosBindingSource2.DataMember = "Proyectos";
            this.proyectosBindingSource2.DataSource = this.toDoProyectDataSet1;
            // 
            // proyectosTableAdapter1
            // 
            this.proyectosTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbProject
            // 
            this.cmbProject.DataSource = this.proyectosBindingSource3;
            this.cmbProject.DisplayMember = "Id_Proyecto";
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(521, 108);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(121, 21);
            this.cmbProject.TabIndex = 80;
            this.cmbProject.ValueMember = "Id_Proyecto";
            // 
            // proyectosBindingSource3
            // 
            this.proyectosBindingSource3.DataMember = "Proyectos";
            this.proyectosBindingSource3.DataSource = this.toDoProyectDataSet3;
            // 
            // toDoProyectDataSet3
            // 
            this.toDoProyectDataSet3.DataSetName = "ToDoProyectDataSet3";
            this.toDoProyectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectosTableAdapter2
            // 
            this.proyectosTableAdapter2.ClearBeforeFill = true;
            // 
            // ActivityCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 450);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttBack);
            this.Controls.Add(this.txtDescription);
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
            this.Controls.Add(this.txtDateLast);
            this.Controls.Add(this.txtDateIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActivityCRUD";
            this.Text = "ActivityCRUD";
            this.Load += new System.EventHandler(this.ActivityCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoProyectDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttBack;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttViewData;
        private System.Windows.Forms.Button bttModify;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.TextBox txtDateLast;
        private System.Windows.Forms.TextBox txtDateIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUser;
        private ToDoProyectDataSet2 toDoProyectDataSet2;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private ToDoProyectDataSet2TableAdapters.ProyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.BindingSource estadoActividadesBindingSource;
        private ToDoProyectDataSet2TableAdapters.EstadoActividadesTableAdapter estadoActividadesTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private ToDoProyectDataSet2TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource proyectosBindingSource1;
        private ToDoProyectDataSet1 toDoProyectDataSet1;
        private System.Windows.Forms.BindingSource proyectosBindingSource2;
        private ToDoProyectDataSet1TableAdapters.ProyectosTableAdapter proyectosTableAdapter1;
        private System.Windows.Forms.ComboBox cmbProject;
        private ToDoProyectDataSet3 toDoProyectDataSet3;
        private System.Windows.Forms.BindingSource proyectosBindingSource3;
        private ToDoProyectDataSet3TableAdapters.ProyectosTableAdapter proyectosTableAdapter2;
    }
}