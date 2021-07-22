using DevExpress.Mvvm;
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
    public class LoginViewModel : ViewModelBase
    {
        private readonly LoginModel _model;

        public LoginViewModel()
        {
            _model = new LoginModel();

            _model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
