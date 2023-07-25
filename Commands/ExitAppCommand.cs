using Notepad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;



namespace Notepadcs.Commands
{
    public class ExitAppCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
