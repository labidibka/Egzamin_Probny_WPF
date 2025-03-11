using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Egzamin_Probny_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string Wygenerowane_Haslo;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int liczba_znakow = int.Parse(znaki.Text);
            Random random = new Random();
           
            string litery =  "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string liczby =  "0123456789";
            string specjalne =  "!@#$%^&*()_+-=";

            string char_ = "";

            if (Wielkie_male.IsChecked == true && Cyfry.IsChecked == false && Specjalne.IsChecked == false)
            {
                char_ += litery;
            }
            else if (Cyfry.IsChecked == true && Wielkie_male.IsChecked == false && Specjalne.IsChecked == false)
            {
                char_ += liczby;
            }
            else if (Specjalne.IsChecked == true && Wielkie_male.IsChecked == false && Cyfry.IsChecked == false)
            {
                char_ += specjalne;
            }
            else if (Specjalne.IsChecked == true && Cyfry.IsChecked == true && Wielkie_male.IsChecked == true) 
            {
                char_ += specjalne;
                char_ += liczby;
                char_ += litery;
            }
            else if (Specjalne.IsChecked == true && Cyfry.IsChecked == false && Wielkie_male.IsChecked == true)
            {
                char_ += specjalne;
                char_ += litery;
            }
            else if (Specjalne.IsChecked == true && Cyfry.IsChecked == true && Wielkie_male.IsChecked == false)
            {
                char_ += specjalne;
                char_ += liczby;
            }
            else if (Specjalne.IsChecked == false && Cyfry.IsChecked == true && Wielkie_male.IsChecked == true)
            {
                char_ += specjalne;
                char_ += liczby;
            }

            char[] tablica = new char[liczba_znakow];

            for (int i = 0; i < tablica.Length; i++) 
            {
                tablica[i] = char_[random.Next(char_.Length)];
            }
           Wygenerowane_Haslo = new string(tablica);

            MessageBox.Show($"Wygenerowane Hasło {Wygenerowane_Haslo}");
            //
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ComboBoxItem Profesja = stanowisko.SelectedItem as ComboBoxItem;
            MessageBox.Show($"Witaj! {imie.Text}, {Nazwisko.Text}, {Profesja.Content}, Hasło Wygenerowane: {Wygenerowane_Haslo}");
        }
    }
}