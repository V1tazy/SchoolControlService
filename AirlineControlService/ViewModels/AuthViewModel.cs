using AirlineControlService.Models;
using AirlineControlService.VIewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AirlineControlService.ViewModels
{
    internal class AuthViewModel: ViewModel
    {
        #region CommandSection
        public ICommand AuthCommand { get; }

        private void OnAuthCommandExecute(object p)
        {
            MessageBox.Show("Негры пидоры");
        }

        private bool CanAuthCommandExecute(object p)
        {
            return true;
        }
        #endregion
    }
}
