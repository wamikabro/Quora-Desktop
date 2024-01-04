using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quora_Desktop.Model;
namespace Quora_Desktop.ViewModel
{
    class HomeVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int UserID
        {
            get { return _pageModel.UserID; }
            set { _pageModel.UserID = value; OnPropertyChanged(); }
        }

        public HomeVM()
        {
            _pageModel= new PageModel();
            UserID = 0;
        }
    }
}
