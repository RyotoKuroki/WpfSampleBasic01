using System;
using System.Windows.Input;
using WpfApp1.ViewModels;

namespace WpfApp1.Extras.Views
{
    internal class AddValueCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private MainWindowViewModel Vm { get; set; }

        /// <summary>コンストラクタ</summary>
        private AddValueCommand()
        {
        }

        /// <summary>コンストラクタ</summary>
        public AddValueCommand(MainWindowViewModel vm)
        {
            // コードビハインドで VM を渡すパターン
            // Command⇔VM の結びつきは強くなる。。。
            this.Vm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return this.Vm != null;
        }

        public void Execute(object? parameter)
        {
            this.Vm.Model.AddValue(int.Parse(parameter.ToString()));
        }
    }
}
