using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleMVCProject.Model;
using System.ComponentModel;

namespace SampleMVCProject.Controller
{
    public interface IView
    {
        void setController(Controller controller);
        void SetDataBinding(BindingList<Model.UserData> bindingSource);
    }
}
