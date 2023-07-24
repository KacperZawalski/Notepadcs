using Notepadcs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Commands
{
    public class SaveAsCommand : CommandBase
    {
        private NotepadM _notepadM;
        public SaveAsCommand(NotepadM notepadM)
        {
            _notepadM = notepadM;
        }
        public override void Execute(object? parameter)
        {
            _notepadM.fileLogic.SaveFileAs(_notepadM.Text);
        }
    }
}
