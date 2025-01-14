using AirlineControlService.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Infrastructure.Commands
{
    class LambdaCommand: BaseCommand
    {
        private readonly Action<object> _Execute;

        private readonly Func<object, bool> _CanExecute;

        public LambdaCommand(Action<object> Execute, Func<object, bool> canExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentException(nameof(Execute));
            _CanExecute = canExecute;
        }

        public override bool CanExecute(object? parameter) => _CanExecute(parameter);

        public override void Execute(object? parameter) => _Execute(parameter);
    }
}
