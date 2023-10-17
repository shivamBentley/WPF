using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Command
{
    public class ViewModel
    {
        public ICommand MyCommand { get; set; } 

        public ViewModel() {

            MyCommand = new Command(ExecuteMethod, CanExecuteMethod);
        }

        private bool CanExecuteMethod(object parameter)
        {
            return true;
        }

        private void ExecuteMethod(object parameter)
        {
            MessageBox.Show("Command Executed No code behind");
        }
    }
}
