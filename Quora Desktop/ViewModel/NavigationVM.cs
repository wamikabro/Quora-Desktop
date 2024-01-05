using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quora_Desktop.Utilities;
using System.Windows.Input;
namespace Quora_Desktop.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand AnswerCommand { get; set; }
        public ICommand FollowingCommand { get; set; }
        public ICommand NotificationsCommand { get; set; }
        public ICommand SpacesCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Answer(object obj) => CurrentView = new AnswerVM();
        private void Following(object obj) => CurrentView = new FollowingVM();
        private void Notifications(object obj) => CurrentView = new NotificationsVM();
        private void Spaces(object obj) => CurrentView = new SpacesVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            AnswerCommand = new RelayCommand(Answer);
            FollowingCommand = new RelayCommand(Following);
            NotificationsCommand = new RelayCommand(Notifications);
            SpacesCommand = new RelayCommand(Spaces);

            // Startup page
            CurrentView = new HomeVM();
        }
    }
}
