using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HWEighteen.Classes
{
    public class Command
    {
        Interfaces.ICommand _command;

        public void SetCommand(Interfaces.ICommand command)
        {
            _command = command;
        }

        public void Run()
        {
            _command.Run();
        }
    }
}
