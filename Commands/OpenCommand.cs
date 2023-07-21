using Notepadcs.Models;
using Notepadcs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Commands
{
    public class OpenCommand : CommandBase
    {
        private NotepadM _notepadM;
        private NotepadViewModel _notepadViewModel;
        public OpenCommand(NotepadM notepadM, NotepadViewModel notepadViewModel)
        {
            _notepadM = notepadM;
            _notepadViewModel = notepadViewModel;
        }
        public override void Execute(object? parameter)
        {
            _notepadViewModel.Text = _notepadM.Text = _notepadM.fileLogic.OpenFile();
            
        }
    }
}
