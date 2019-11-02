using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Models;

namespace SOLID
{
    class Presenter
    {
        IModel IModel;
        IMainView IMainView;
        public Presenter(IMainView _IView, IModel _IModel)
        {
            Model Mod = new Model(new ReadDB);
            IMainView = _IView;
            IModel = _IModel;
        }
    }
}
