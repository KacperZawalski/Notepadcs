using Notepadcs.Commands;
using Notepadcs.Models;
using Notepadcs.Stores;
using System;
using System.Windows.Input;

namespace Notepadcs.ViewModels
{
    public class FontViewModel : ViewModelBase
    {
        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }
        public string FontWeight
        {
            get
            {
                return _fontWeight;
            }
            set
            {
                _fontWeight = value;
                OnPropertyChanged(nameof(FontWeight));
            }
        }
        public string[] FontFamilyNames
        {
            get
            {
                return _fontFamilyNames;
            }
        }
        public string FontStyling
        {
            get
            {
                return _fontStyling;
            }
            set
            {
                _fontStyling = value.Substring(37);
                if (_fontStyling.Equals("Bold"))
                {
                    _fontStyle = "Normal";
                    _fontWeight = "Bold";
                    OnPropertyChanged(nameof(FontStyle));
                    OnPropertyChanged(nameof(FontWeight));
                }
                else if (_fontStyling.Equals("Italic"))
                {
                    _fontStyle = "Italic";
                    _fontWeight = "Regular";
                    OnPropertyChanged(nameof(FontStyle));
                    OnPropertyChanged(nameof(FontWeight));
                }
                else if (_fontStyling.Equals("Bold Italic"))
                {
                    _fontStyle = "Italic";
                    _fontWeight = "Bold";
                    OnPropertyChanged(nameof(FontStyle));
                    OnPropertyChanged(nameof(FontWeight));
                }
                else
                {
                    _fontStyle = "Normal";
                    _fontWeight = "Regular";
                    OnPropertyChanged(nameof(FontStyle));
                    OnPropertyChanged(nameof(FontWeight));
                }
                OnPropertyChanged(nameof(FontStyling));
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
        public float[] FontSizes
        {
            get
            {
                return _fontSizes;
            }
        }
        public FontViewModel(FontLogic fontLogic, NotepadM notepadM, NavigationStore navigationStore)
        {
            initializeData(fontLogic);
            OkCommand = new FontCommand(this, notepadM, navigationStore);
            CancelCommand = new CancelFontCommand();
        }

        private string[] _fontFamilyNames;
        private FontLogic _fontLogic = new FontLogic();
        private float _fontSize;
        private string _fontName;
        private string _fontStyle;
        private string _fontWeight;
        private string _fontStyling;
        private const int fontSizeListLenght = 100;
        private float[] _fontSizes;

        private void initializeData(FontLogic fontLogic)
        {
            _fontSizes = new float[fontSizeListLenght];
            for (int i = 0; i < fontSizeListLenght; i++)
            {
                _fontSizes[i] = i + 1;
            }
            _fontSize = _fontLogic.Font.Size;
            _fontStyle = _fontLogic.Font.Style.ToString();
            _fontName = _fontLogic.Font.Name.ToString();
            _fontWeight = _fontLogic.Font.Style.ToString();
            _fontFamilyNames = new string[fontLogic.FontFamilyNames.Length];
            Array.Copy(_fontLogic.FontFamilyNames, FontFamilyNames, _fontLogic.FontFamilyNames.Length);
        }
    }
}
