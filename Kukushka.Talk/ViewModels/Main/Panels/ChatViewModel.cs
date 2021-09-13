using Concentus.Structs;
using DevExpress.Mvvm;
using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Open.Nat;
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
                var discoverer = new NatDiscoverer();
                var cts = new CancellationTokenSource(10000);
                var device = await discoverer.DiscoverDeviceAsync(PortMapper.Upnp, cts);

                await device.CreatePortMapAsync(new Mapping(Protocol.Tcp, 1600, 1600, "Kukushka Port Forwarding"));
            });
        }

        public ICommand TestClickCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
