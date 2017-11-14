using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Shared.MVVM
{
    public class MvvmCommand : ICommand
    {
        public Action<object> _execute { get; }
        public Func<object, bool> _canExecute { get; }

        public event EventHandler CanExecuteChanged;

        public MvvmCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
            => _canExecute != null
                ? _canExecute(parameter)
                : true;

        public void Execute(object parameter)
            => _execute(parameter);
    }
}
