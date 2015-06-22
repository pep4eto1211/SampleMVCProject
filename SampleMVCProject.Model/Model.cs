using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVCProject.Model
{
    public class Model : INotifyPropertyChanged
    {
        public Model()
        {
            users.ListChanged += users_ListChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void users_ListChanged(object sender, ListChangedEventArgs e)
        {
            RaisePropertyChanged("CanAddMoreUsers");
        }

        public bool CanAddMoreUsers
        {
            get 
            {
                return this.users.Count <= 5;
            }
        }

        private string errorMessage = "";

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { this.errorMessage = value;
            RaisePropertyChanged("ErrorMessage");
            }
        }

        public BindingList<UserData> users = new BindingList<UserData>();

        public BindingList<UserData> Users
        {
            get { return users; }
        }

        private bool isIdValid(int id)
        {
            foreach (UserData singleUser in users)
            {
                if (singleUser.Id == id)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddNewUser(string Name, string Department, int Age, int Id)
        {
            if ((isIdValid(Id)) && (Name != "") && (Department != ""))
            {
                users.Add(new UserData(Id, Age, Name, Department));
                if (users.Count > 5)
                {
                    RaisePropertyChanged("CanAddMoreUsers");
                    ErrorMessage = "";
                }   
            }
            else
            {
                ErrorMessage = "Invalid input data";
                
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
