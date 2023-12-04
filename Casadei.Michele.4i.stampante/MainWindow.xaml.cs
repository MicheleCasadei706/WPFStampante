using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Casadei.Michele._4i.stampante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Models.Stampante stampante = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cyan_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisiciColore("cyan");
            updater();
        }

        private void magenta_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisiciColore("magenta");
            updater();
        }

        private void yellow_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisiciColore("yellow");
            updater();
        }

        private void black_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisiciColore("black");
            updater();
        }

        private void paper_Click(object sender, RoutedEventArgs e)
        {
            int p = Convert.ToInt32(qtaPaper.Text);
            stampante.AggiungiCarta(p);
            updater();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {

            Models.Pagina p = new Models.Pagina();

            if (stampante.Stampa(p))
            {
                statusPrint.Background = Brushes.Green;
                statusPrint.Foreground = Brushes.White;
            }
            else
            {
                statusPrint.Background = Brushes.Red;
                statusPrint.Foreground = Brushes.White;
            }

            updater();
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            int c = Convert.ToInt32(qtaCyan.Text);
            int m = Convert.ToInt32(qtaMagenta.Text);
            int y = Convert.ToInt32(qtaYellow.Text);
            int b = Convert.ToInt32(qtaBlack.Text);

            qtaCyan.Text = "0";
            qtaMagenta.Text = "0";
            qtaYellow.Text = "0";
            qtaBlack.Text = "0";

            try
            {
                Models.Pagina p = new Models.Pagina(c, m, y, b);

                if (stampante.Stampa(p))
                {
                    statusPrint.Background = Brushes.Green;
                    statusPrint.Foreground = Brushes.White;
                }
                else
                {
                    statusPrint.Background = Brushes.Red;
                    statusPrint.Foreground = Brushes.White;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            updater();
        }

        private void updater()
        {
            resources.Text = "Livello inchiostro: \n\n" +
                             $"Ciano {stampante.C}% \n" +
                             $"Magenta {stampante.M}% \n" +
                             $"Giallo {stampante.Y}% \n" +
                             $"Nero {stampante.B}% \n\n\n" +
                             $"Nel cassetto ci sono {stampante.Fogli}/200 fogli";
        }
    }
}
