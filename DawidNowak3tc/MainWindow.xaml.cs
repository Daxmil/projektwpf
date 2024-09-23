using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DawidNowak3tc
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Zadanie> Zadania { get; set; }

        public MainWindow()
        {
            InitializeComponent();
          
            ZmienJezyk();
            Zadania = new ObservableCollection<Zadanie>();
            ListaZadan.ItemsSource = Zadania;

        }

        private void NoweZadanie_Click(object sender, RoutedEventArgs e)
        {
            var oknoZadania = new TaskWindow();
            if (oknoZadania.ShowDialog() == true)
            {
                Zadania.Add(oknoZadania.Zadanie);
                if (Properties.Settings.Default.Jezyk == "pl")
                {
                    StatusText.Text = "Dodano nowe zadanie.";
                }
                else if(Properties.Settings.Default.Jezyk == "en")
                {
                    StatusText.Text = "A new task has been added.";
                }
            }
        }

        private void EdytujZadanie_Click(object sender, RoutedEventArgs e)
        {
            if (ListaZadan.SelectedItem is Zadanie wybraneZadanie)
            {
                var oknoZadania = new TaskWindow(wybraneZadanie);
                if (oknoZadania.ShowDialog() == true)
                {
                    int index = Zadania.IndexOf(wybraneZadanie);
                    Zadania[index] = oknoZadania.Zadanie;
                    ListaZadan.Items.Refresh();
                    if (Properties.Settings.Default.Jezyk == "pl")
                    {
                        StatusText.Text = "Edytowano zadanie.";
                    }
                    else if (Properties.Settings.Default.Jezyk == "en")
                    {
                        StatusText.Text = "The task has been edited.";
                    }
                }
            }
        }

        private void UsunZadanie_Click(object sender, RoutedEventArgs e)
        {
            if (ListaZadan.SelectedItem is Zadanie wybraneZadanie)
            {
                Zadania.Remove(wybraneZadanie);
                if (Properties.Settings.Default.Jezyk == "pl")
                {
                    StatusText.Text = "Usunięto zadanie.";
                }
                else if (Properties.Settings.Default.Jezyk == "en")
                {
                    StatusText.Text = "Task deleted.";
                }
            }
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Zadania.Clear();
            if (Properties.Settings.Default.Jezyk == "pl")
            {
                StatusText.Text = "Zresetowano liste.";
            }
            else if (Properties.Settings.Default.Jezyk == "en")
            {
                StatusText.Text = "List reset.";
            }

        }

        private void Ustawienia_Click(object sender, RoutedEventArgs e)
        {
            var oknoUstawien = new SettingsWindow();
            oknoUstawien.ShowDialog();
        }

        private void Zakonczenie_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ss_Click(object sender, RoutedEventArgs e)
        {
            DockPanel mainDockPanel = (DockPanel)FindName("MainDockPanel");

            if (mainDockPanel != null)
            {
                RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int)mainDockPanel.ActualWidth,
                                                                              (int)mainDockPanel.ActualHeight,
                                                                              96, 96, PixelFormats.Pbgra32);
                renderTargetBitmap.Render(mainDockPanel);

                PngBitmapEncoder pngEncoder = new PngBitmapEncoder();
                pngEncoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, $"screenshot_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png");

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    pngEncoder.Save(fileStream);
                }
                if (Properties.Settings.Default.Jezyk == "pl")
                {
                    MessageBox.Show($"Zrzut ekranu został zapisany jako {filePath}");
                    StatusText.Text = "Wykonano zrzut";
                }
                else if (Properties.Settings.Default.Jezyk == "en")
                {
                    MessageBox.Show($"The screenshot was saved as {filePath}");
                    StatusText.Text = "ScreenShot completed";
                }

            }
            else
            {
                if (Properties.Settings.Default.Jezyk == "pl")
                {
                    MessageBox.Show("Nie Wykonano zrzutu");
                    StatusText.Text = "Nie Wykonano zrzutu";
                }
                else if (Properties.Settings.Default.Jezyk == "en")
                {
                    MessageBox.Show("No ScreenShot taken");
                    StatusText.Text = "No ScreenShot taken";
                }

                
            }
        }
        public void ZmienJezyk()
        {
            if (Properties.Settings.Default.Jezyk == "pl")
            {
                Title = "Zarządzanie Zadaniami";
                Plik.Header = "Plik";
                Menu1.Header = "Zrób zrzut";
                Menu2.Header = "Ustawienia";
                Menu3.Header = "Zakończ";
                Dodaj.Content = "Dodaj zadanie";
                Reset.Content = "Wyczyść";
                Zadanie.Header = "Zadanie";
                Opis.Header = "Opis";
                Wykonane.Header = "Wykonane";
                Edytuj.Content = "Edytuj zadanie";
                Usun.Content = "Usun zadanie";
                StatusText.Text = "Gotowy";
            }
            else if (Properties.Settings.Default.Jezyk == "en")
            {
                Title = "Task Management";
                Plik.Header = "File";
                Menu1.Header = "Take ScreenShot";
                Menu2.Header = "Settings";
                Menu3.Header = "Close";
                Dodaj.Content = "Add task";
                Reset.Content = "Reset";
                Zadanie.Header = "Task";
                Opis.Header = "Description";
                Wykonane.Header = "Completed";
                Edytuj.Content = "Edit task";
                Usun.Content = "Delete task";
                StatusText.Text = "Ready";
            }

        }
        private void ListaZadan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

  