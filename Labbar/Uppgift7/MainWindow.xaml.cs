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

namespace Uppgift7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int tal1, tal2, heltal, rest;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void beräkningsknapp_Click(object sender, RoutedEventArgs e)
        {
            tal1 = Convert.ToInt32(tal1ruta.Text);
            tal2 = Convert.ToInt32(tal2ruta.Text);
            heltal = tal1 / tal2;
            rest = tal1 % tal2;
            heltalbox.Text = Convert.ToString(heltal);
            restbox.Text = Convert.ToString(rest);
        }
    }
}
