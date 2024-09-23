using System.Windows;

namespace DawidNowak3tc
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Jezyk == "pl")
            {
                Title = "Ustawienia";
                SettingsLabel.Content = "Ustawienia";
                Zastosuj.Content = "Zastosuj";
            }
            else if (Properties.Settings.Default.Jezyk == "en")
            {
                Title = "Settings";
                SettingsLabel.Content = "Settings";
                Zastosuj.Content = "Submit";
            }

        }

        private void ZastosujButton_Click(object sender, RoutedEventArgs e)
        {
            string jezyk = Properties.Settings.Default.Jezyk;

            if (Polski.IsChecked == true)
            {
                jezyk = "pl";
            }
            else if (Angielski.IsChecked == true)
            {
                jezyk = "en";
            }

            Properties.Settings.Default.Jezyk = jezyk;
            Properties.Settings.Default.Save();

            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.ZmienJezyk();
            }

            this.Close();
        }
    }
}
