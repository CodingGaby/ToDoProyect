namespace ToDoProyect.Pages.CRUD
{
    partial class ProjectCRUD
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
            this.projectStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trelloProyectDBDataSet = new ToDoProyect.TrelloProyectDBDataSet();
            this.estadosProyectosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estadosProyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosProyectosTableAdapter = new ToDoProyect.TrelloProyectDBDataSetTableAdapters.projectStatesTableAdapter();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.bttBack = new System.Windows.Forms.Button();
            this.txtDateLast = new System.Windows.Forms.TextBox();
            this.txtDateIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trelloProyectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosProyectosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosProyectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(621, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Descripcion";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(366, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Id";
            // 
            // bttViewData
            // 
            this.bttViewData.Location = new System.Drawing.Point(995, 221);
            this.bttViewData.Name = "bttViewData";
            this.bttViewData.Size = new System.Drawing.Size(75, 23);
            this.bttViewData.TabIndex = 45;
            this.bttViewData.Text = "Vizualizar";
            this.bttViewData.UseVisualStyleBackColor = true;
            this.bttViewData.Click += new System.EventHandler(this.bttViewData_Click);
            // 
            // bttModify
            // 
            this.bttModify.Location = new System.Drawing.Point(481, 221);
            this.bttModify.Name = "bttModify";
            this.bttModify.Size = new System.Drawing.Size(75, 23);
            this.bttModify.TabIndex = 44;
            this.bttModify.Text = "Modificar";
            this.bttModify.UseVisualStyleBackColor = true;
            this.bttModify.Click += new System.EventHandler(this.bttModify_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(617, 221);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 43;
            this.bttDelete.Text = "Dar de Baja";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(351, 221);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 42;
            this.bttAdd.Text = "Crear";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(117, 259);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(944, 150);
            this.dataView.TabIndex = 41;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Estado";
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DataSource = this.projectStatesBindingSource;
            this.cmbEstatus.DisplayMember = "name";
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Location = new System.Drawing.Point(428, 108);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(121, 21);
            this.cmbEstatus.TabIndex = 39;
            this.cmbEstatus.ValueMember = "idState";
            // 
            // projectStatesBindingSource
            // 
            this.projectStatesBindingSource.DataMember = "projectStates";
            this.projectStatesBindingSource.DataSource = this.trelloProyectDBDataSet;
            // 
            // trelloProyectDBDataSet
            // 
            this.trelloProyectDBDataSet.DataSetName = "ToDoProyectDataSet1";
            this.trelloProyectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosProyectosBindingSource1
            // 
            this.estadosProyectosBindingSource1.DataMember = "projectStates";
            this.estadosProyectosBindingSource1.DataSource = this.trelloProyectDBDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha Entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha Ingresado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Projects";
            // 
            // estadosProyectosBindingSource
            // 
            this.estadosProyectosBindingSource.DataMember = "projectStates";
            this.estadosProyectosBindingSource.DataSource = this.trelloProyectDBDataSet;
            // 
            // estadosProyectosTableAdapter
            // 
            this.estadosProyectosTableAdapter.ClearBeforeFill = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(707, 108);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(354, 90);
            this.txtDescription.TabIndex = 49;
            this.txtDescription.Text = "";
            // 
            // bttBack
            // 
            this.bttBack.Location = new System.Drawing.Point(495, 50);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(75, 23);
            this.bttBack.TabIndex = 50;
            this.bttBack.Text = "Regresar";
            this.bttBack.UseVisualStyleBackColor = true;
            this.bttBack.Click += new System.EventHandler(this.bttBack_Click);
            // 
            // txtDateLast
            // 
            this.txtDateLast.Location = new System.Drawing.Point(210, 185);
            this.txtDateLast.Name = "txtDateLast";
            this.txtDateLast.Size = new System.Drawing.Size(100, 20);
            this.txtDateLast.TabIndex = 33;
            // 
            // txtDateIn
            // 
            this.txtDateIn.Location = new System.Drawing.Point(210, 148);
            this.txtDateIn.Name = "txtDateIn";
            this.txtDateIn.Size = new System.Drawing.Size(100, 20);
            this.txtDateIn.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(103, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "*Date format - dd/mm/yyyy";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Nombre del Proyecto";
            // 
            // ProjectCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
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
            this.Name = "ProjectCRUD";
            this.Text = "ProjectCRUD";
            this.Load += new System.EventHandler(this.ProjectCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trelloProyectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosProyectosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosProyectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TrelloProyectDBDataSet trelloProyectDBDataSet;
        private System.Windows.Forms.BindingSource estadosProyectosBindingSource;
        private TrelloProyectDBDataSetTableAdapters.projectStatesTableAdapter estadosProyectosTableAdapter;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button bttBack;
        private System.Windows.Forms.BindingSource estadosProyectosBindingSource1;
        private System.Windows.Forms.TextBox txtDateLast;
        private System.Windows.Forms.TextBox txtDateIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource projectStatesBindingSource;
    }
}