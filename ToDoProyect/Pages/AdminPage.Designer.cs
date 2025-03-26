namespace ToDoProyect.Pages
{
    partial class AdminPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttAddUser = new System.Windows.Forms.Button();
            this.bttProjects = new System.Windows.Forms.Button();
            this.bttActivity = new System.Windows.Forms.Button();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Page";
            // 
            // bttAddUser
            // 
            this.bttAddUser.Location = new System.Drawing.Point(40, 106);
            this.bttAddUser.Name = "bttAddUser";
            this.bttAddUser.Size = new System.Drawing.Size(75, 23);
            this.bttAddUser.TabIndex = 1;
            this.bttAddUser.Text = "Users";
            this.bttAddUser.UseVisualStyleBackColor = true;
            this.bttAddUser.Click += new System.EventHandler(this.bttAddUser_Click);
            // 
            // bttProjects
            // 
            this.bttProjects.Location = new System.Drawing.Point(40, 68);
            this.bttProjects.Name = "bttProjects";
            this.bttProjects.Size = new System.Drawing.Size(75, 23);
            this.bttProjects.TabIndex = 2;
            this.bttProjects.Text = "Projects";
            this.bttProjects.UseVisualStyleBackColor = true;
            this.bttProjects.Click += new System.EventHandler(this.bttProjects_Click);
            // 
            // bttActivity
            // 
            this.bttActivity.Location = new System.Drawing.Point(40, 146);
            this.bttActivity.Name = "bttActivity";
            this.bttActivity.Size = new System.Drawing.Size(75, 23);
            this.bttActivity.TabIndex = 3;
            this.bttActivity.Text = "Activities";
            this.bttActivity.UseVisualStyleBackColor = true;
            this.bttActivity.Click += new System.EventHandler(this.bttActivity_Click);
            // 
            // bttLogOut
            // 
            this.bttLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttLogOut.Location = new System.Drawing.Point(27, 223);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(114, 23);
            this.bttLogOut.TabIndex = 4;
            this.bttLogOut.Text = "Cerrar Sesion";
            this.bttLogOut.UseVisualStyleBackColor = false;
            this.bttLogOut.Click += new System.EventHandler(this.bttLogOut_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 258);
            this.Controls.Add(this.bttLogOut);
            this.Controls.Add(this.bttActivity);
            this.Controls.Add(this.bttProjects);
            this.Controls.Add(this.bttAddUser);
            this.Controls.Add(this.label1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttAddUser;
        private System.Windows.Forms.Button bttProjects;
        private System.Windows.Forms.Button bttActivity;
        private System.Windows.Forms.Button bttLogOut;
    }
}