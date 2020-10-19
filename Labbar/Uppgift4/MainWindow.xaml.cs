using System;
using System.Collections.Generic;
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

namespace Uppgift4
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

        private void måndag_Click(object sender, RoutedEventArgs e)
        {
            veckodagsPresentatör.Content = "Du klickade på knappen Måndag";
        }

        private void tisdag_Click(object sender, RoutedEventArgs e)
        {
            veckodagsPresentatör.Content = "Du klickade på knappen Tisdag";
        }

        private void onsdag_Click(object sender, RoutedEventArgs e)
        {
            veckodagsPresentatör.Content = "Du klickade på knappen Onsdag";
        }

        private void torsdag_Click(object sender, RoutedEventArgs e)
        {
            veckodagsPresentatör.Content = "Du klickade på knappen Torsdag";
        }

        private void fredag_Click(object sender, RoutedEventArgs e)
        {
            veckodagsPresentatör.Content = "Du klickade på knappen Fredag";
        }

        private void lördag_Click(object sender, RoutedEventArgs e)
        {
            veckodagsPresentatör.Content = "Du klickade på knappen Lördag";
        }

        private void söndag_Click(object sender, RoutedEventArgs e)
        {
            veckodagsPresentatör.Content = "Du klickade på knappen Söndag";
        }

    }
}
