using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SumMvvm.ViewModels.Commons
{
    public class CommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action _Action;
        bool _CanExecute;

        public CommandHandler(Action action, bool canExecute)
        {
            _Action = action;
            _CanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _CanExecute;
        }

        public void Execute(object parameter)
        {
            _Action();
        }
    }
}
