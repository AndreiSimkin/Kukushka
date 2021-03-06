using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Kukushka.Talk.Models.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Kukushka.Talk.ViewModels.Auth
{
    public class MenuViewModel : ViewModelBase
    {
        private readonly MenuModel _model;

        public MenuViewModel()
        {
            _model = new MenuModel();

            _model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);

            LoginCommand = new DelegateCommand(() =>
            {
                Views.Shared.Layout.NavigationService.Navigate(new Views.Auth.Login());
            });

            RegisterCommand = new DelegateCommand(() =>
            {
                Views.Shared.Layout.NavigationService.Navigate(new Views.Auth.Register());
            });
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
