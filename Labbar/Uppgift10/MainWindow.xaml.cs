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

namespace Uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int rättSvar;
        int användarensSvar;
        int avvikelse;



        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void slumpatal_Click(object sender, RoutedEventArgs e)
        {
            
            rättSvar = random.Next(0, 1000);
            // resultattext.Text = Convert.ToString(rättSvar);
            
        }

        private void Gissa_Click(object sender, RoutedEventArgs e)
        {
            användarensSvar = int.Parse(talet.Text);
            avvikelse = Math.Abs(rättSvar - användarensSvar);
            if (användarensSvar == rättSvar)
            {
                resultattext.Text = "Grattis, du gissade rätt!";
            }

            else if (användarensSvar < rättSvar && avvikelse < 100)
            {
                resultattext.Text = "Oj, du gissade lite för högt!";
            }
            else if (användarensSvar > rättSvar && avvikelse < 100)
            {
                resultattext.Text = "Oj, du gissade lite för lågt!";
            }
            else if (användarensSvar > rättSvar && avvikelse > 100)
            {
                resultattext.Text = "Du gissade alldeles för högt.";
            }
            else if (användarensSvar < rättSvar && avvikelse > 100)
            {
                resultattext.Text = "Du gissade alldeles för lågt.";
            }
        }
    }
}
