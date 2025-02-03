using AirlineControlService.Infrastructure.Commands.Base;
using System;

namespace AirlineControlService.Infrastructure.Commands
{
    class LambdaCommand : BaseCommand
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool>? _CanExecute;

        public LambdaCommand(Action<object> Execute, Func<object, bool>? canExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = canExecute;
        }

        public override bool CanExecute(object? parameter) => _CanExecute == null || _CanExecute(parameter);

        public override void Execute(object? parameter) => _Execute(parameter);
    }
}
