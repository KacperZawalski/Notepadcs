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
    public class NotepadToFontCommand : CommandBase
    {
        private NotepadM _notepadM;
        private readonly NavigationStore _navigationStore;
        public NotepadToFontCommand(NavigationStore navigationStore, NotepadM notepadM)
        {
            _notepadM = notepadM;
            _navigationStore = navigationStore;  
        }
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new FontViewModel(_notepadM.fontLogic, _notepadM, _navigationStore);
        }
    }
}
