using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoProyect.Pages.CRUD;

namespace ToDoProyect.Pages
{
    public partial class AdminPage: Form
    {
        public AdminPage(string v)
        {
            InitializeComponent();
        }

        private void bttAddUser_Click(object sender, EventArgs e)
        {
            Hide();
            new UserCRUD().Show();
        }

        private void bttProjects_Click(object sender, EventArgs e)
        {
            Hide();
            new ProjectCRUD().Show();
        }

        private void bttActivity_Click(object sender, EventArgs e)
        {
            Hide();
            new ActivityCRUD().Show();
        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            new MainPage().Show();
        }
    }
}
