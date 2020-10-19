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

namespace Uppgift3
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

        private bool knapp1Klickad = false;
        private bool knapp2Klickad = false;

        private void knapp1_Click(object sender, RoutedEventArgs e)
        {
            knapp1Klickad = true;
            if (knapp1Klickad == true)
            {
                knapp1.Content = "Klickad";
                knapp2.Content = "Oklickad";
            }
        }

        private void knapp2_Click(object sender, RoutedEventArgs e)
        {
            knapp2Klickad = true;
            if (knapp2Klickad == true)
            {
                knapp1.Content = "Oklickad";
                knapp2.Content = "Klickad";
            }
        }
    }
}
