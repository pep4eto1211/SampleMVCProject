using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleMVCProject.Controller;

namespace SampleMVCProject.View
{
    public partial class View : Form, IView
    {
        private Controller.Controller currentController;

        public View()
        {
            InitializeComponent();
            
        }

        public void SetDataBinding(BindingList<Model.UserData> bindingSource)
        {
            dataGrid.DataSource = bindingSource;
        }

        private int usersCount = 0;

        private int UsrersCount
        {
            get
            {
                return usersCount;
            }
            set 
            {
                this.usersCount = value;
                AddUserPanel.Visible = usersCount <= 5;
            }
        }

        public void setController(Controller.Controller controller)
        {
            this.currentController = controller;
            //AddUserPanel.DataBindings.Add("Visible", currentController.CurrentModel, "CanAddMoreUsers");
            errorBox.DataBindings.Add("Text", currentController.CurrentModel, "ErrorMessage");
            this.DataBindings.Add("UsersCount", currentController.CurrentModel.users, "Count");
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            currentController.CurrentModel.AddNewUser(nameBox.Text, departmentBox.Text, int.Parse(ageBox.Text), int.Parse(idBox.Text));
            nameBox.Text = "";
            departmentBox.Text = "";
            ageBox.Text = "";
            idBox.Text = "";
        }
    }
}
