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

            TestCommand = new DelegateCommand(() => {
                Views.Shared.Layout.NavigationService.Navigate(new Views.Main.Messenger());
            });
        }

        public ICommand TestCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
