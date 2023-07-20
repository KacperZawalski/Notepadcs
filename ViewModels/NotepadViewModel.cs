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
                _notepadM.Text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public NotepadViewModel(NavigationStore navigationStore, NotepadM notepadM)
        {
            _notepadM = notepadM;
            _text = notepadM.Text;
            ToFontCommand = new NotepadToFontCommand(navigationStore, notepadM);
        }
        private NotepadM _notepadM;
        private float _fontSize => _notepadM.fontLogic.FontSize;
        private string _fontName => _notepadM.fontLogic.FontName;
        private string _fontStyle => _notepadM.fontLogic.FontStyle;
        private string _fontWeight => _notepadM.fontLogic.FontWeight;
        private string _text;

    }
}
