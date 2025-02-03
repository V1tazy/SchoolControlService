using AirlineControlService.Infrastructure.Commands;
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
    class AdminViewModel: ViewModel
    {
        #region Command

        public ICommand ScheduleSelectCommand { get; }
        public ICommand ChildSelectCommand { get; }
        public ICommand UserSelectCommand { get; }

        private void OnScheduleSelectCommand(object p) 
        {
            MessageBox.Show("Расписание");
        }

        private void OnChildSelectCommand(object p) 
        {
            MessageBox.Show("Дети");
        }

        private void OnUserSelectCommand(object p) 
        {
            MessageBox.Show("Пользователи");
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
