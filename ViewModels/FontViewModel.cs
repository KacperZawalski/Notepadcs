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
        public FontViewModel(NotepadM notepadM, NavigationStore navigationStore)
        {
            _notepadM = notepadM;
            initializeData();
            OkCommand = new FontCommand(this, notepadM, navigationStore);
            CancelCommand = new CancelFontCommand(navigationStore, notepadM);
        }

        private NotepadM _notepadM;
        private string[] _fontFamilyNames;
        private float _fontSize;
        private string _fontName;
        private string _fontStyle;
        private string _fontWeight;
        private string _fontStyling;
        private const int fontSizeListLenght = 100;
        private float[] _fontSizes;

        private void initializeData()
        {
            _fontSizes = new float[fontSizeListLenght];
            for (int i = 0; i < fontSizeListLenght; i++)
            {
                _fontSizes[i] = i + 1;
            }
            _fontStyling = _notepadM.fontLogic.FontWeight + " " + _notepadM.fontLogic.FontStyle;
            _fontSize = _notepadM.fontLogic.FontSize;
            _fontStyle = (_notepadM.fontLogic.FontStyle.Equals("Regular") ? "Normal" : _notepadM.fontLogic.FontStyle);
            _fontName = _notepadM.fontLogic.FontName;
            _fontWeight = _notepadM.fontLogic.FontWeight;
            _fontFamilyNames = new string[_notepadM.fontLogic.FontFamilyNames.Length];
            Array.Copy(_notepadM.fontLogic.FontFamilyNames, FontFamilyNames, _notepadM.fontLogic.FontFamilyNames.Length);
        }
    }
}
