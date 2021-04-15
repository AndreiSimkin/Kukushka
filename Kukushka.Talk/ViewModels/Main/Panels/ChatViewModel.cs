using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kukushka.Talk.ViewModels.Main.Panels
{
    public class ChatViewModel : ViewModelBase
    {
        public ChatViewModel()
        {

            TestClickCommand = new DelegateCommand(() => { });
        }

        public ICommand TestClickCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
