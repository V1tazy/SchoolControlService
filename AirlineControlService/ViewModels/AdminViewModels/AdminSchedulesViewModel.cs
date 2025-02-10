using AirlineControlService.DAL.Entityes;
using AirlineControlService.Infrastructure.Commands;
using AirlineControlService.Interfaces;
using AirlineControlService.Services.Interface.Admin;
using AirlineControlService.VIewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AirlineControlService.ViewModels.AdminViewModels
{
    internal class AdminSchedulesViewModel : ViewModel
    {
        private readonly IAdminService _adminService;
        private readonly IRepository<Schedule> _schedulesRepository;

        private Schedule _schedule;
        public Schedule Schedule
        {
            get => _schedule;
            set => Set(ref _schedule, value);
        }

        public ObservableCollection<Schedule> Schedules { get; }

        #region Commands

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand RemoveCommand { get; }

        #endregion

        public AdminSchedulesViewModel(IRepository<Schedule> schedulesRepository)
        {
            _schedulesRepository = schedulesRepository ?? throw new ArgumentNullException(nameof(schedulesRepository));
            _adminService = App.Services.GetService<IAdminService>();

            Schedules = new ObservableCollection<Schedule>(_schedulesRepository.items);

            AddCommand = new LambdaCommand(OnAddCommand, CanExecuteAlways);
            EditCommand = new LambdaCommand(OnEditCommand, CanExecuteWhenSelected);
            RemoveCommand = new LambdaCommand(OnRemoveCommand, CanExecuteWhenSelected);
        }

        #region Command Conditions

        private bool CanExecuteAlways(object p) => true;

        private bool CanExecuteWhenSelected(object p) => Schedule != null;

        #endregion

        #region Command Actions

        private async void OnAddCommand(object p)
        {
            var newSchedule = new Schedule
            {
                // Заполни данные расписания
                Description = "Новое расписание"
            };

            var addedSchedule = await _adminService.Add(newSchedule);
            if (addedSchedule is Schedule schedule)
                Schedules.Add(schedule);
        }

        private async void OnEditCommand(object p)
        {
            if (Schedule is null) return;

            var updatedSchedule = await _adminService.Update(Schedule);
            if (updatedSchedule is Schedule updated)
            {
                var index = Schedules.IndexOf(Schedule);
                if (index >= 0)
                    Schedules[index] = updated;
            }
        }

        private async void OnRemoveCommand(object p)
        {
            if (Schedule is null) return;

            await _adminService.Remove(Schedule.Id);
        }

        #endregion
    }
}
