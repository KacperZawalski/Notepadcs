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
        private string FilePath;
        public FileLogic ()
        {
            FilePath = "";
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
                    FilePath = openFileDialog.FileName;
                    return File.ReadAllText(FilePath);
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
                    FilePath = saveFileDialog.FileName;
                    File.WriteAllText(FilePath, FileContent);
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
                File.WriteAllText(FilePath, FileContent);
            }
            catch
            {
                MessageBox.Show("Couldn't save the file");
            }
        }
        public void ResetFilePath()
        {
            FilePath = "";
        }
    }
}
