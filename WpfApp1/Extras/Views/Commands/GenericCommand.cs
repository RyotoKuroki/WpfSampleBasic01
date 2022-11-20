using System;
using System.Windows.Input;

namespace WpfApp1.Extras.Views
{
    internal class GenericCommand : ICommand
    {
        // 処理内容自体を外から渡すことで、VM に依存しない汎用的な処理が可能
        public Action<object?> GenericAction { get; set; }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter == null)
            {
                throw new NotImplementedException($"コマンドパラメータを正しく実装して下さい。\r\n{Environment.StackTrace}");
            }

            // VM に依存しないパターン
            this.GenericAction(parameter);
        }
    }
}
