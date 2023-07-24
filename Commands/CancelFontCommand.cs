using Notepadcs.Models;
using Notepadcs.Stores;
using Notepadcs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Commands
{
    public class CancelFontCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        private NotepadM _notepadM;
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new NotepadViewModel(_navigationStore, _notepadM);
        }
        public CancelFontCommand(NavigationStore navigationStore, NotepadM notepadM)
        {
            _notepadM = notepadM;
            _navigationStore = navigationStore;
        }
    }
}
