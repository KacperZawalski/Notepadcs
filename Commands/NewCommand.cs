using Notepadcs.Models;
using Notepadcs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

            if (MessageBox.Show("Do you want to save changes before creating fresh page?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (_notepadM.fileLogic.FilePath.Equals(""))
                {
                    _notepadM.fileLogic.SaveFileAs(_notepadViewModel.Text);
                }
                else
                {
                    _notepadM.fileLogic.SaveFile(_notepadViewModel.Text);
                }
                _notepadM.fileLogic.ResetFilePath();
                _notepadM.Text = _notepadViewModel.Text = "";
            }
            else
            {
                _notepadM.fileLogic.ResetFilePath();
                _notepadM.Text = _notepadViewModel.Text = "";
            }

        }
    }
}
