using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using System.Windows.Threading;

namespace Kukushka.Talk.Views.Shared
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Layout : Window
    {
        public Layout()
        {
            InitializeComponent();
            NavigationService = PageFrame.NavigationService;
        }

        public static NavigationService NavigationService { get; private set; }

        private void LayoutWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Keyboard.FocusedElement != null)
            {
                var textBox = (FrameworkElement)Keyboard.FocusedElement;
                FrameworkElement parent = (FrameworkElement)textBox.Parent;
                while (parent != null && parent is IInputElement && !((IInputElement)parent).Focusable)
                {
                    parent = (FrameworkElement)parent.Parent;
                }

                DependencyObject scope = FocusManager.GetFocusScope(textBox);
                FocusManager.SetFocusedElement(scope, parent as IInputElement);
            }
        }

        int start = 1;

        private bool _allowDirectNavigation = false;
        private NavigatingCancelEventArgs _navArgs = null;
        private Duration _duration = new Duration(TimeSpan.FromMilliseconds(100));

        private void PageFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (start > 0)
            {
                start--;
                return;
            }

            if (Content != null && !_allowDirectNavigation)
            {
                e.Cancel = true;

                _navArgs = e;

                DoubleAnimation animation0 = new DoubleAnimation();
                animation0.EasingFunction = new ExponentialEase() { EasingMode = EasingMode.EaseOut, Exponent = 1 };
                animation0.From = 1;
                animation0.To = 0;
                animation0.Duration = _duration;
                animation0.Completed += SlideCompleted;
                PageFrame.BeginAnimation(OpacityProperty, animation0);
            }
            _allowDirectNavigation = false;
        }

        private void SlideCompleted(object sender, EventArgs e)
        {
            _allowDirectNavigation = true;
            switch (_navArgs.NavigationMode)
            {
                case NavigationMode.New:
                    if (_navArgs.Uri == null)
                        PageFrame.Navigate(_navArgs.Content);
                    else
                        PageFrame.Navigate(_navArgs.Uri);
                    break;
                case NavigationMode.Back:
                    PageFrame.GoBack();
                    break;
                case NavigationMode.Forward:
                    PageFrame.GoForward();
                    break;
                case NavigationMode.Refresh:
                    PageFrame.Refresh();
                    break;
            }

            Dispatcher.BeginInvoke(DispatcherPriority.Loaded,
                (ThreadStart)delegate ()
                {
                    DoubleAnimation animation0 = new DoubleAnimation();
                    animation0.EasingFunction = new ExponentialEase() { EasingMode = EasingMode.EaseOut, Exponent = 1 };
                    animation0.From = 0;
                    animation0.To = 1;
                    animation0.Duration = _duration;
                    PageFrame.BeginAnimation(OpacityProperty, animation0);
                });
        }

    }
}
