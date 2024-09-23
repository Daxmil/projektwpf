using System.Windows;

namespace DawidNowak3tc
{
    public partial class TaskWindow : Window
    {
        public Zadanie Zadanie { get; private set; }

        public TaskWindow()
        {
            InitializeComponent();
            Zadanie = new Zadanie();
            DataContext = Zadanie;

            if (Properties.Settings.Default.Jezyk == "pl")
            {
                Title = "Nowe zadanie";
                Nazwa.Text = "Nazwa zadania:";
                Opis.Text = "Opis zadania: ";
                CzyWykonaneCheckBox.Content = "Wykonane";
                Zapisz.Content = "Zapisz";
                Anuluj.Content = "Anuluj";
            }
            else if (Properties.Settings.Default.Jezyk == "en")
            {
                Title = "New task";
                Nazwa.Text = "Task name:";
                Opis.Text = "Task description: ";
                CzyWykonaneCheckBox.Content = "Completed";
                Zapisz.Content = "Save";
                Anuluj.Content = "Cancel";
            }
        }

        public TaskWindow(Zadanie zadanie) : this()
        {
            Zadanie = zadanie;
            DataContext = Zadanie;
        }

        private void ZapiszButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void AnulujButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}