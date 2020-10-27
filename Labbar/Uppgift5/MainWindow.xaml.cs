using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

namespace Uppgift5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nummer1, nummer2, summa;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void beräkna_Click(object sender, RoutedEventArgs e)
        {
            nummer1 = Convert.ToInt32(tal1ruta.Text);
            nummer2 = Convert.ToInt32(tal2ruta.Text);
            summa = nummer1 + nummer2;
            summaruta.Text = Convert.ToString(summa);
            
        }

        private void rensa_Click(object sender, RoutedEventArgs e)
        {
            tal1ruta.Clear();
            tal2ruta.Clear();
            summaruta.Clear();
        }

        private void tal1ruta_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tal2ruta_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void summaruta_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
