using SumMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMvvm.VMLocator
{
    public class VMLocator
    {
        static MainWindowViewModel _MainWindowViewModel;

        public static MainWindowViewModel MainWindowViewModel
        {
            get
            {
                return _MainWindowViewModel ?? (_MainWindowViewModel = new MainWindowViewModel());
            }

        }
    }
}
