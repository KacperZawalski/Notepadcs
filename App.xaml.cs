using Notepadcs.Models;
using Notepadcs.Stores;
using Notepadcs.ViewModels;
using System.Windows;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly NotepadM _notepadM;
        public App()
        {
            _notepadM = new NotepadM();
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new NotepadViewModel(_navigationStore, _notepadM);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
