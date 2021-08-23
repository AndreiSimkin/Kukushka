using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Kukushka.Talk.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Kukushka.Talk.ViewModels.Shared
{
    public class LayoutViewModel : ViewModelBase
    {
        private readonly LayoutModel _model;

        public LayoutViewModel()
        {
            _model = new LayoutModel();

            _model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
