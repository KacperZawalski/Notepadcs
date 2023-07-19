using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepadcs.Models
{
    public class FontLogic
    {
        public string []FontFamilyNames;
        public string FontName;
        public string FontStyle;
        public string FontWeight;
        public float FontSize;
        private Font _font = new Font(FontFamily.GenericSansSerif, 12.0F, System.Drawing.FontStyle.Regular);

        public Font Font
        {
            get 
            { 
                return _font; 
            }
            set 
            {
                if (value.Size > 0)
                {
                    _font = value;
                }
            }
        }
        private InstalledFontCollection installedFontCollection = new InstalledFontCollection();
        public FontFamily[] fontFamilies;
        public FontLogic()
        {
            InitializeFontFamilyNames();
        }
        private void InitializeFontFamilyNames()
        {
            fontFamilies = installedFontCollection.Families;
            FontFamilyNames = new string[fontFamilies.Length];
            for (int i = 0; i < fontFamilies.Length; i++)
            {
                FontFamilyNames[i] = fontFamilies[i].Name;
            }
        }


    }
}
