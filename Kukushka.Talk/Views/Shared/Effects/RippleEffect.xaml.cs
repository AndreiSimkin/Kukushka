using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kukushka.Talk.Views.Shared.Effects
{
    /// <summary>
    /// Логика взаимодействия для RippleEffect.xaml
    /// </summary>
    public partial class RippleEffect : UserControl
    {
        public RippleEffect()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty RoundMaskColorProperty =
  DependencyProperty.Register(
    "RoundMaskColor", typeof(Brush), typeof(RippleEffect), new PropertyMetadata(Brushes.Transparent));

        public Brush RoundMaskColor
        {
            get { return (Brush)GetValue(RoundMaskColorProperty); }
            set { SetValue(RoundMaskColorProperty, value); }
        }

    }
}
