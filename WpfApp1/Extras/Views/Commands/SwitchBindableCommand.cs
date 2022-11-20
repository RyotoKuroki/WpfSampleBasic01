using System;
using System.Windows.Input;
using WpfApp1.ViewModels;

namespace WpfApp1.Extras.Views
{
    internal class SwitchBindableCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            // Xaml上で ConverterParameter に VM を渡すパターン
            // Command⇔VM の結びつきは強くなる。。。
            var vm = (MainWindowViewModel)parameter;
            vm.Model.SetNow();
        }
    }
}
