using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.VIewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AirlineControlService.ViewModels
{
    class AdminViewModel: ViewModel
    {
        #region Command

        public ICommand ScheduleSelectCommand { get; }
        public ICommand ChildSelectCommand { get; }
        public ICommand UserSelectCommand { get; }

        private async void OnScheduleSelectCommand(object p) 
        {

        }

        private async void OnChildSelectCommand(object p) 
        {
            
        }

        private async void OnUserSelectCommand(object p) 
        {

        }

        #endregion



        public AdminViewModel() 
        {
            ScheduleSelectCommand = new LambdaCommand(OnScheduleSelectCommand);
            ChildSelectCommand = new LambdaCommand(OnChildSelectCommand);
            UserSelectCommand = new LambdaCommand(OnUserSelectCommand);
        }
    }
}
