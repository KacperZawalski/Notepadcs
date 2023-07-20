using Notepadcs.Models;
using Notepadcs.Stores;
using Notepadcs.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Commands
{
    internal class FontCommand : CommandBase
    {
        private NotepadM _notepadM;
        private FontViewModel _fontViewModel;
        private readonly NavigationStore _navigationStore;
        public FontCommand(ViewModels.FontViewModel fontViewModel, Models.NotepadM notepadM, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _fontViewModel = fontViewModel;
            _notepadM = notepadM;
        }
        public override void Execute(object? parameter)
        {
            _notepadM.fontLogic.FontWeight = _fontViewModel.FontWeight;
            _notepadM.fontLogic.FontStyle = _fontViewModel.FontStyle;
            _notepadM.fontLogic.FontName = _fontViewModel.FontName;
            _notepadM.fontLogic.FontSize = _fontViewModel.FontSize;

            _navigationStore.CurrentViewModel = new NotepadViewModel(_navigationStore, _notepadM);
        }
    }
}
