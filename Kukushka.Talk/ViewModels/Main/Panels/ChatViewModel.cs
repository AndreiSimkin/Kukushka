using Concentus.Structs;
using DevExpress.Mvvm;
using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kukushka.Talk.ViewModels.Main.Panels
{
    public class ChatViewModel : ViewModelBase
    {
        public ChatViewModel()
        {
            TestClickCommand = new DelegateCommand(async () =>
            {
             //   var test = await Network.Client.Connection.GetStunAdress();
            });
        }

        public ICommand TestClickCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
