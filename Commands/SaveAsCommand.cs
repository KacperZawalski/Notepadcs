using Notepadcs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Commands
{
<<<<<<< HEAD
    public class SaveAsCommand
=======
    public class SaveAsCommand : CommandBase
>>>>>>> 4958a0f9ea6b931791cf0ab855b36d6cf70a67df
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
