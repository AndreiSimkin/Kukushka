using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Kukushka.Talk.Models.Shared.Effects;

namespace Kukushka.Talk.ViewModels.Shared.Effects
{
    [POCOViewModel]
    public class RippleEffectViewModel : ViewModelBase
    {
        private RippleEffectModel Model;

        public Point EllipseStartPos => Model.EllipseStartPos;
        public Point EllipseEndPos => Model.EllipseEndPos;
        public double TargetWidth => Model.TargetWidth;
        public string CurrentElipse => Model.CurrentElipse;
        public Size RoundMaskSize => Model.RoundMaskSize;

        public RippleEffectViewModel()
        {
            Model = new RippleEffectModel();
            Model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
        }

        public ICommand ActivateCommand => new DelegateCommand<object>((args) => Model.Activate(args));
        public ICommand DeactivateCommand => new DelegateCommand<object>((args) => Model.Decativate(args));
        public ICommand InitializeCommand => new DelegateCommand<object>((args) => Model.Initialize(args));
    }
}
