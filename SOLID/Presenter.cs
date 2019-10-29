using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Presenter
    {
        IModel IModel;
        IMainView IMainView;
        public Presenter(IMainView _IView, IModel _IModel)
        {
            IMainView = _IView;
            IModel = _IModel;

        }
    }
}
