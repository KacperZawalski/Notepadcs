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
        public string FileContent { get; set; }
        public FileLogic ()
        {
            FilePath = "";
            FileContent = "";
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
                    FileContent = File.ReadAllText(FilePath);
                }
                return FileContent;
            }
            catch
            {
                MessageBox.Show("Couldn't open the file.");
            }
            return "";
        }
        public void SaveFile()
        {
            try
            {
                if (FilePath != "")
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
                else
                {
                    File.WriteAllText(FilePath, FileContent);
                }
                
            }
            catch
            {
                MessageBox.Show("Couldn't save the file");
            }
        }
    }
}
