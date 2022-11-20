using System;
using System.Windows.Input;
using WpfApp1.ViewModels;

namespace WpfApp1.Extras.Views
{
    internal class LostFocusCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private MainWindowViewModel Vm { get; set; }

        private LostFocusCommand()
        {
        }

        public LostFocusCommand(MainWindowViewModel vm)
        {
            this.Vm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return this.Vm != null;
        }

        public void Execute(object? parameter)
        {
            this.Vm.Model.Data.SomeValue = "ლ(╹◡╹ლ)";
        }
    }
}
