using DevExpress.Mvvm;
using Kukushka.Talk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Kukushka.Talk.ViewModels.Main
{
    public class MessengerViewModel : ViewModelBase
    {
        private readonly MessangerModel _model;

        public MessengerViewModel()
        {
            _model = new MessangerModel();

            _model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
