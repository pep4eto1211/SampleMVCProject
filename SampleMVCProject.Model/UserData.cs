using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleMVCProject.Model;

namespace SampleMVCProject.Model
{
    public class UserData
    {
        private int age;
        private int id;
        private string name;
        private string department;

        public UserData(int id, int age, string name, string department)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.department = department;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
