using System.Windows;
using System.Windows.Input;
using WinAlBackup.ViewModels;

namespace WinAlBackup
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                ((MainViewModel)DataContext).ReloadBackupFiles();
            }
        }
    }
}
