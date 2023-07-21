using Notepadcs.Models;
using Notepadcs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Commands
{
    public class NewCommand : CommandBase
    {
        private NotepadM _notepadM;
        private NotepadViewModel _notepadViewModel;
        public NewCommand(NotepadM notepadM, NotepadViewModel notepadViewModel)
        {
            _notepadM = notepadM;
            _notepadViewModel = notepadViewModel;
        }
        public override void Execute(object? parameter)
        {
            _notepadM.fileLogic.ResetFilePath();
            _notepadM.Text = _notepadViewModel.Text = "";
        }
    }
}
