using Notepadcs.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Notepadcs.ViewModels
{
    public class FontViewModel : ViewModelBase
    {
        private readonly FontLogic _fontLogic;

        private string _fontStyle => _fontLogic.font.Style.ToString();
        private string _fontName => _fontLogic.font.Name.ToString();
        private float _fontSize;
        public string FontStyle
        {
            get
            {
                return _fontStyle;
            }
            set
            {
                OnPropertyChanged(nameof(FontStyle));
            }
        }

        public string FontName
        {
            get
            {
                return _fontName;
            }
            set
            {
                OnPropertyChanged(nameof(FontName));
            }
        }
        
        public float FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                OnPropertyChanged(nameof(_fontSize));
            }
        }

        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }
        private readonly float[] _fontSizes = new float[] {1, 8, 9, 20};
        public float[] FontSizes => _fontSizes;
        public FontViewModel(FontLogic fontLogic)
        {
            _fontLogic = fontLogic;
        }
    }
}
