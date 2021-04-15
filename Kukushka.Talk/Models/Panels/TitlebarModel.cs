﻿using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kukushka.Talk.Models.Panels
{
    public class TitleBarModel : BindableBase
    {
        public void TougleWindowState(WindowState state)
        {
            if (WindowState == WindowState.Maximized && state == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = state;
            RaisePropertiesChanged("WindowState");
        }

        public void CloseWindow()
        {
            Application.Current.Shutdown();
        }

        public WindowState WindowState { get; set; }
    }
}
