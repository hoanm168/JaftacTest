using SumMvvm.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SumMvvm.ViewModels
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {

        int _X ;

        int _Y;

        int _SumResult;

        public int X
        {
            get
            {
                return _X;
            }

            set
            {
                _X = value;
                SendPropertyChanged("X");
            }
        }

        public int Y
        {
            get
            {
                return _Y;
            }

            set
            {
                _Y = value;
                SendPropertyChanged("Y");
            }
        }



        public int SumResult
        {
            get
            {
                return _SumResult;
            }

            set
            {
                _SumResult = value;
                SendPropertyChanged("SumResult");
            }
        }

        ICommand _SumCommand;
        public ICommand SumCommand
        {
            get
            {
                return _SumCommand ?? (_SumCommand = new CommandHandler(() => Sum(), CanExecute));
            }

            //set
            //{
            //    _SumCommand = value;
            //}
        }



        public void Sum()
        {
            SumResult = X + Y;
        }

        private bool canExecute = true;
        public bool CanExecute
        {
            get
            {
                return canExecute;
            }

            set
            {
                canExecute = value;
                SendPropertyChanged("CanExecute");
            }
        }
    }
}
