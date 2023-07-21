using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using FontFamily = System.Drawing.FontFamily;
using FontStyle = System.Drawing.FontStyle;

namespace Notepadcs.Models
{
    public class NotepadM
    {
        public string Text { get; set; }
        public FontLogic fontLogic;
        public FileLogic fileLogic;
        public NotepadM()
        {
            Text = "";
            fontLogic = new FontLogic();
            fileLogic = new FileLogic();
        }
    }
}
