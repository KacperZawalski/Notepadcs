using Notepadcs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Commands
{
    public class SaveCommand : CommandBase
    {
        private NotepadM _notepadM;
        public SaveCommand(NotepadM notepadM)
        {
            _notepadM = notepadM;
        }
        public override void Execute(object? parameter)
        {
            _notepadM.fileLogic.SaveFile(_notepadM.Text);
        }
    }
}
