using Crossroads.View;
using Crossroads.ViewModel;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crossroads.ViewModel
{
    internal class MainWindowVM : ViewModelBase
    {
        private Page _CurPage = new HomePage();
        private Page Home = new HomePage();
        private Page Profile = new ProfilePage();
        private Page Rooms = new RoomsPage();
        private Page Clients = new ClientsPage();
        private Page Support = new SupportPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        #region Команды
        public ICommand OpenProfilePage
        {
            get { return new RelayCommand(()=> CurPage = Profile); }
        }
        public ICommand OpenHomePage
        {
            get { return new RelayCommand(() => CurPage = Home); }
        }
        public ICommand OpenRoomsPage
        {
            get { return new RelayCommand(() => CurPage = Rooms); }
        }
        public ICommand OpenClientsPage
        {
            get { return new RelayCommand(() => CurPage = Clients); }
        }
        public ICommand OpenSupportPage
        {
            get { return new RelayCommand(() => CurPage = Support); }
        }
        public ICommand CloseApp
        {
            get { return new RelayCommand(() => Application.Current.Shutdown()); }
        }
        #endregion
    }
}
