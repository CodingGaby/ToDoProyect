namespace ToDoProyect
{
    partial class UserPage
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttBack = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bttViewData = new System.Windows.Forms.Button();
            this.bttWaiting = new System.Windows.Forms.Button();
            this.bttComplete = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateIn = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(357, 247);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(354, 20);
            this.txtUrl.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "URL Documento";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(155, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Nombre de la Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(270, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "*Date format - dd/mm/yyyy";
            // 
            // bttBack
            // 
            this.bttBack.Location = new System.Drawing.Point(555, 341);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(75, 23);
            this.bttBack.TabIndex = 97;
            this.bttBack.Text = "Regresar";
            this.bttBack.UseVisualStyleBackColor = true;
            this.bttBack.Click += new System.EventHandler(this.bttBack_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(60, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Id";
            // 
            // bttViewData
            // 
            this.bttViewData.Location = new System.Drawing.Point(636, 341);
            this.bttViewData.Name = "bttViewData";
            this.bttViewData.Size = new System.Drawing.Size(75, 23);
            this.bttViewData.TabIndex = 92;
            this.bttViewData.Text = "Ver Tareas";
            this.bttViewData.UseVisualStyleBackColor = true;
            this.bttViewData.Click += new System.EventHandler(this.bttViewData_Click);
            // 
            // bttWaiting
            // 
            this.bttWaiting.Location = new System.Drawing.Point(172, 341);
            this.bttWaiting.Name = "bttWaiting";
            this.bttWaiting.Size = new System.Drawing.Size(75, 23);
            this.bttWaiting.TabIndex = 91;
            this.bttWaiting.Text = "En Espera";
            this.bttWaiting.UseVisualStyleBackColor = true;
            this.bttWaiting.Click += new System.EventHandler(this.bttWaiting_Click);
            // 
            // bttComplete
            // 
            this.bttComplete.Location = new System.Drawing.Point(60, 341);
            this.bttComplete.Name = "bttComplete";
            this.bttComplete.Size = new System.Drawing.Size(75, 23);
            this.bttComplete.TabIndex = 90;
            this.bttComplete.Text = "Completado";
            this.bttComplete.UseVisualStyleBackColor = true;
            this.bttComplete.Click += new System.EventHandler(this.bttComplete_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(51, 383);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(663, 150);
            this.dataView.TabIndex = 88;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Estado";
            // 
            // txtDateLast
            // 
            this.txtDateLast.Location = new System.Drawing.Point(155, 197);
            this.txtDateLast.Name = "txtDateLast";
            this.txtDateLast.Size = new System.Drawing.Size(100, 20);
            this.txtDateLast.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Fecha Entrega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 81;
            this.label1.Text = "Bienvenido";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(166, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 31);
            this.lblUser.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "Descripcion";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(360, 120);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(354, 71);
            this.txtDescription.TabIndex = 96;
            this.txtDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Fecha Ingresado";
            // 
            // txtDateIn
            // 
            this.txtDateIn.Enabled = false;
            this.txtDateIn.Location = new System.Drawing.Point(155, 160);
            this.txtDateIn.Name = "txtDateIn";
            this.txtDateIn.Size = new System.Drawing.Size(100, 20);
            this.txtDateIn.TabIndex = 84;
            // 
            // txtProject
            // 
            this.txtProject.Enabled = false;
            this.txtProject.Location = new System.Drawing.Point(154, 240);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(100, 20);
            this.txtProject.TabIndex = 108;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(154, 280);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 109;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 555);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.bttWaiting);
            this.Controls.Add(this.bttComplete);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDateLast);
            this.Controls.Add(this.txtDateIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserPage";
            this.Text = "UserPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttBack;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttViewData;
        private System.Windows.Forms.Button bttWaiting;
        private System.Windows.Forms.Button bttComplete;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDateLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateIn;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtStatus;
    }
}