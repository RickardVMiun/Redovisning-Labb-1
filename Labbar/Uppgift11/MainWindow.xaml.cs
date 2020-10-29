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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random sannolikhet = new Random();
        int användarensAntal;
        int tur;
       
        
         

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mindreotur_Click(object sender, RoutedEventArgs e)
        {
            bar.Value -= 5;
            tur += 5;
            
        }

        private void merotur_Click(object sender, RoutedEventArgs e)
        {
            bar.Value += 5;
            tur -= 5;
            
        }

        private void starta_Click(object sender, RoutedEventArgs e)
        {
            int rätthåll = 0;
            int felhåll = 0;
            användarensAntal = int.Parse(försök.Text);
            tur = Convert.ToInt32(bar.Value);

            for (int i = 0; i < användarensAntal; i++)
            {
                int flipp = sannolikhet.Next(1,101);
                if (flipp > tur)
                {
                    rätthåll++;
                }
                else
                {
                    felhåll++;
                }
            }
            rätthållsiffror.Content = rätthåll;
            felhållsiffror.Content = felhåll;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }
    }
}
