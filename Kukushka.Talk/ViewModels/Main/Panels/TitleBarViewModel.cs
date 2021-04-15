using DevExpress.Mvvm;
using Kukushka.Talk.Models.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Kukushka.Talk.ViewModels.Main.Panels
{
    public class TitleBarViewModel : ViewModelBase
    {
        private readonly TitleBarModel _model;

        public TitleBarViewModel()
        {
            _model = new TitleBarModel();

            _model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);

            WindowStateChangedCommand = new DelegateCommand<WindowState>(_model.TougleWindowState);
            WindowCloseCommand = new DelegateCommand(_model.CloseWindow);
        }

        public ICommand WindowStateChangedCommand { get; set; }
        public ICommand WindowCloseCommand { get; set; }

        public WindowState WindowState { get { return _model.WindowState; } set { _model.WindowState = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
