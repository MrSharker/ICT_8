using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;
        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }
        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }
        public void Undo()
        {
            commands[current - 1].UnExecute();
        }
        public void Redo()
        {
            commands[current - 1].Execute();
            commands.Add(commands[current - 1]);
            current++;
        }
        public void Undo(int levels)
        {
            int k = current;
            for (int i = 0; i < levels; i++)
            {
                commands[k - 1].UnExecute();
                k--;
            }
        }
        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                commands[current - 1].Execute();
                commands.Add(commands[current - 1]);
                current++;
            }
        }
    }
}
