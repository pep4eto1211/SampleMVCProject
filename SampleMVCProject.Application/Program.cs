using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleMVCProject.View;
using SampleMVCProject.Model;
using SampleMVCProject.Controller;

namespace SampleMVCProject.Application
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            View.View view = new View.View();
            Model.Model model = new Model.Model();
            Controller.Controller controller = new Controller.Controller(view, model);
            model.AddNewUser("Peter Georgiev", "Software", 19, 1);
            model.AddNewUser("Georgi Petrov", "Software", 21, 2);
            model.AddNewUser("Ivan Petrov", "Software", 23, 3);
            model.AddNewUser("Petar Ivanov", "Software", 19, 4);
            model.AddNewUser("Ivan Petrov", "Software", 23, 5);
            model.AddNewUser("Petar Ivanov", "Software", 19, 6);
            view.ShowDialog();
        }
    }
}
