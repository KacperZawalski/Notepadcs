using Notepadcs.Commands;
using Notepadcs.Models;
using Notepadcs.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Notepadcs.ViewModels
{
    public class NotepadViewModel : ViewModelBase
    {
        public ICommand ToFontCommand { get; }
        public float FontSize
        {
            get
            {
                return _fontSize;
            }
        }
        public string FontWeight
        {
            get
            {
                return _fontWeight;
            }
        }
        public string FontStyle
        {
            get
            {
                return _fontStyle;
            }
        }
        public string FontName
        {
            get
            {
                return _fontName;
            }
        }
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public NotepadViewModel(NavigationStore navigationStore, NotepadM notepadM)
        {
            ToFontCommand = new NotepadToFontCommand(navigationStore, notepadM);
        }

        private FontLogic _fontLogic = new FontLogic();
        private float _fontSize => _fontLogic.FontSize;
        private string _fontName => _fontLogic.FontName;
        private string _fontStyle => _fontLogic.FontStyle;
        private string _fontWeight => _fontLogic.FontWeight;
        private string _text;

    }
}
