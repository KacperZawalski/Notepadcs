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
        private Font _font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Regular);

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
        private FontFamily[] fontFamilies;
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
