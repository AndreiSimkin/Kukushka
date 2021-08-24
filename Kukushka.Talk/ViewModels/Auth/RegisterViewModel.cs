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
    public class RegisterViewModel : ViewModelBase
    {
        private readonly RegisterModel _model;

        public RegisterViewModel()
        {
            _model = new RegisterModel();

            _model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);

            RegisterCommand = new DelegateCommand(() => {
                Views.Shared.Layout.NavigationService.Navigate(new Views.Main.Messenger());
            });
        }

        public ICommand RegisterCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
