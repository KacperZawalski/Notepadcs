using Notepadcs.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        private float _fontSize;
        private string _fontName;
        private string _fontStyle;
        private string _fontWeight;
        private string _fontStyling;
        public string FontStyling
        {
            get 
            { 
                return _fontStyling; 
            }
            set 
            { 
                _fontStyling = value; 
            }
        }
        public string FontStyle
        {
            get
            {
                return _fontStyle;
            }
            set
            {
                _fontStyle = value.Substring(37);
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
                _fontName = value;
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
                if (value > 0)
                {
                    _fontSize = value;
                    OnPropertyChanged(nameof(FontSize));
                }       
            }
        }

        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }
        private readonly float[] _fontSizes = new float[] {1, 8, 9, 20};
        public float[] FontSizes => _fontSizes;
        public FontViewModel(FontLogic fontLogic)
        {
            _fontSize = fontLogic.font.Size;
            _fontStyle = fontLogic.font.Style.ToString();
            _fontName = fontLogic.font.Name.ToString();
        }
    }
}
