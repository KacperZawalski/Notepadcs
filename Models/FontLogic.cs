using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notepadcs.Models
{
    public class FontLogic
    {
        public string[] FontFamilyNames;
        public string FontName;
        public string FontStyle;
        public string FontWeight;
        public float FontSize;

        private InstalledFontCollection installedFontCollection = new InstalledFontCollection();
        public FontFamily[] fontFamilies;
        public FontLogic()
        {
            InitializeFontFamilyNames();
            InitializeFontData();
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
        private void InitializeFontData()
        {
            FontName = "Arial";
            FontStyle = FontStyles.Normal.ToString();
            FontWeight = FontStyles.Normal.ToString();
            FontSize = 16;
        }

    }


}

