using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notepadcs.Models
{
    public class FileLogic
    {
        public string FilePath
        {
            get
            {
                return filePath;
            }
        }
        private string filePath;
        public FileLogic ()
        {
            filePath = "";
        }
        public string OpenFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
               
                if (openFileDialog.ShowDialog() == true)
                {
                    filePath = openFileDialog.FileName;
                    return File.ReadAllText(filePath);
                }
            }
            catch
            {
                MessageBox.Show("Couldn't open the file.");
            }
            return "";
        }
        public void SaveFileAs(string FileContent)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.OverwritePrompt = true;

                if (saveFileDialog.ShowDialog() == true)
                {
                    filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, FileContent);
                }            
            }
            catch
            {
                MessageBox.Show("Couldn't save the file x");
            }
        }
        public void SaveFile(string FileContent)
        {
            try
            {
                File.WriteAllText(filePath, FileContent);
            }
            catch
            {
                MessageBox.Show("Couldn't save the file");
            }
        }
        public void ResetFilePath()
        {
            filePath = "";
        }
    }
}
