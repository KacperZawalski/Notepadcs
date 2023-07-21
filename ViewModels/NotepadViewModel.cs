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
        public ICommand SaveFileAsCommand { get; }
        public ICommand SaveFileCommand { get; }
        public ICommand OpenFileCommand { get; }
        public ICommand NewFileCommand { get; }
        public float FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
                _notepadM.fontLogic.FontSize = value;
                OnPropertyChanged(nameof(FontSize));
            }
        }
        public string FontWeight
        {
            get
            {
                return _fontWeight;
            }
            set
            {
                _fontWeight = value;
                _notepadM.fontLogic.FontWeight = value;
                OnPropertyChanged(nameof(FontWeight));
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
                _fontStyle = value;
                _notepadM.fontLogic.FontStyle = value;
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
                _notepadM.fontLogic.FontName = value;
                OnPropertyChanged(nameof(FontName));
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
            _fontSize = notepadM.fontLogic.FontSize;
            _fontName = notepadM.fontLogic.FontName;
            _fontStyle = notepadM.fontLogic.FontStyle;
            _fontWeight = notepadM.fontLogic.FontWeight;

            ToFontCommand = new NotepadToFontCommand(navigationStore, notepadM);
            SaveFileAsCommand = new SaveAsCommand(notepadM);
            SaveFileCommand = new SaveCommand(notepadM);
            OpenFileCommand = new OpenCommand(notepadM, this);
            NewFileCommand = new NewCommand(notepadM, this);
        }
        private NotepadM _notepadM;
        private float _fontSize;
        private string _fontName;
        private string _fontStyle;
        private string _fontWeight;
        private string _text;

    }
}
