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

namespace Kukushka.Talk.Views.Shared.Elements
{
    /// <summary>
    /// Логика взаимодействия для Button.xaml
    /// </summary>
    public partial class Button : UserControl
    {
        public Button()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty CommandProperty =
                DependencyProperty.Register(
                "Command",
                typeof(ICommand),
                typeof(Button));

        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }

            set
            {
                SetValue(CommandProperty, value);
            }
        }



        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CommandParameter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object), typeof(Button));




        public bool EnableRippleEffect
        {
            get { return (bool)GetValue(EnableRippleEffectProperty); }
            set { SetValue(EnableRippleEffectProperty, value); }
        }



        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(int), typeof(Button), new PropertyMetadata(0));





        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Transparent));



        // Using a DependencyProperty as the backing store for EnableRippleEffect.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnableRippleEffectProperty =
            DependencyProperty.Register("EnableRippleEffect", typeof(bool), typeof(Button), new PropertyMetadata(true));



        public Brush ButtonIconStroke
        {
            get { return (Brush)GetValue(ButtonIconStrokeProperty); }
            set { SetValue(ButtonIconStrokeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonIconStroke.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonIconStrokeProperty =
            DependencyProperty.Register("ButtonIconStroke", typeof(Brush), typeof(Button), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(128, 128, 128 ))));

        public Brush MouseOverButtonIconStroke
        {
            get { return (Brush)GetValue(MouseOverButtonIconStrokeProperty); }
            set { SetValue(MouseOverButtonIconStrokeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverButtonIconStroke.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverButtonIconStrokeProperty =
            DependencyProperty.Register("MouseOverButtonIconStroke", typeof(Brush), typeof(Button), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(220, 220, 220))));


    }
}
