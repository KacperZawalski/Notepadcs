using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepadcs.ViewModels
{
    public class FontViewModel : ViewModelBase
    {
        private string _fontStyle;
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
        private string _fontName;
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
        private float _fontSize;
        public float FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                OnPropertyChanged(nameof(FontSize));
            }
        }
        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }
        private readonly string[] _fontSizes = new string[] {"1", "2", "3" };
        public string[] FontSizes => _fontSizes;
        public FontViewModel()
        {

        }
    }
}
