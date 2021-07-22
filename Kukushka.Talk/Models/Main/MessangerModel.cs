using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kukushka.Talk.Models.Main
{
    public class MessangerModel : BindableBase
    {
        public void TougleWindowState(WindowState state)
        {
            if (WindowState == WindowState.Maximized && state == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = state;
            RaisePropertiesChanged("WindowState");
        }

        public WindowState WindowState { get; set; }
    }
}
