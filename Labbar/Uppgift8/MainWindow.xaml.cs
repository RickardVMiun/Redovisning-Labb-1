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

namespace Uppgift8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double tal1, tal2, summa;
        

       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void subtraktion_Checked(object sender, RoutedEventArgs e)
        {
          
        }

        private void multiplikation_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void division_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void addition_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void beräknaknapp_Click(object sender, RoutedEventArgs e)
        {
            tal1 = Convert.ToDouble(tal1box.Text);
            tal2 = Convert.ToDouble(tal2box.Text);
            if (Convert.ToBoolean(subtraktion.IsChecked))
            {
                resultatbox.Text = Convert.ToString(tal1 - tal2);
            }
            else if (Convert.ToBoolean(multiplikation.IsChecked))
            {
                resultatbox.Text = Convert.ToString(tal1 + tal2);
            }
            else if (Convert.ToBoolean(addition.IsChecked))
            {
                resultatbox.Text = Convert.ToString(tal1 * tal2);
            }
            else if (Convert.ToBoolean(division.IsChecked))
            {
                summa = Math.Round(tal1 / tal2, 2);
                resultatbox.Text = Convert.ToString(summa);
            }
        }
    }
}
