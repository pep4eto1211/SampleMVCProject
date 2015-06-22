using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVCProject.Controller
{
    public class Controller
    {
        private IView currentView;
        private Model.Model currentModel;

        public Model.Model CurrentModel
        {
            get { return currentModel; }
        }

        public string name = "Controller";

        public Controller(IView currentView, Model.Model model)
        {
            this.currentView = currentView;
            this.currentModel = model;
            currentView.setController(this);
            currentView.SetDataBinding(currentModel.Users);
        }
    }
}
