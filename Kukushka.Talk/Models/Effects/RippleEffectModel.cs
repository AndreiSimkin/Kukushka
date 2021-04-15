using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using Kukushka.Talk.Views;

namespace Kukushka.Talk.Models.Effects
{
    public class RippleEffectModel : BindableBase
    {
        public Point EllipseStartPos { get; set; }
        public Point EllipseEndPos { get; set; }
        public double TargetWidth { get; set; }
        public string CurrentElipse { get; set; } = "ellipse1";
        public Size RoundMaskSize { get; set; }

        public void Initialize(object args)
        {
            FrameworkElement rippe = (args as RoutedEventArgs).Source as FrameworkElement;
            RoundMaskSize = new Size((int)rippe.ActualWidth + 20, rippe.ActualHeight + 20);
            RaisePropertiesChanged("RoundMaskSize");
        }

        public void Activate(object args)
        {
            MouseEventArgs mouse = args as MouseEventArgs;
            Mouse.Capture(mouse.Source as IInputElement);
            Point position = mouse.GetPosition(mouse.Source as UIElement);
            TargetWidth = Math.Max((mouse.Source as FrameworkElement).ActualWidth * 2, (mouse.Source as FrameworkElement).ActualHeight) * 2;
            EllipseStartPos = new Point(position.X, position.Y);
            EllipseEndPos = new Point(position.X - TargetWidth / 2, position.Y - TargetWidth / 2);
            CurrentElipse = CurrentElipse == "ellipse1" ? "ellipse2" : "ellipse1";
            RaisePropertiesChanged("EllipseStartPos", "EllipseEndPos", "TargetWidth", "CurrentElipse");
        }

        public void Decativate(object args)
        {
            Mouse.Capture(null);
        }
    }
}
