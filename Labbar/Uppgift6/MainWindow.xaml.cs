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

namespace Uppgift6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double tal1, tal2, resultat;
        private bool plusklickad = false;
        private bool minusklickad = false;
        private bool gångerklickad = false;
        private bool delatklickad = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rensa_Click(object sender, RoutedEventArgs e)
        {
            summa.Clear();
            tal1text.Clear();
            tal2text.Clear();
            operand.Content = "Resultat";
        }

        private void summa_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void tal1text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tal2text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            plusklickad = true;
            tal1 = Convert.ToDouble(tal1text.Text);
            tal2 = Convert.ToDouble(tal2text.Text);
            resultat = tal1 + tal2;
            summa.Text = Convert.ToString(resultat);

            if (plusklickad == true)
            {
                operand.Content = "Summa";
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            minusklickad = true;
            tal1 = Convert.ToDouble(tal1text.Text);
            tal2 = Convert.ToDouble(tal2text.Text);
            resultat = tal1 - tal2;
            summa.Text = Convert.ToString(resultat);

            if (minusklickad == true)
            {
                operand.Content = "Differens";
            }
        }

        private void gånger_Click(object sender, RoutedEventArgs e)
        {
            gångerklickad = true;
            tal1 = Convert.ToDouble(tal1text.Text);
            tal2 = Convert.ToDouble(tal2text.Text);
            resultat = tal1 * tal2;
            summa.Text = Convert.ToString(resultat);

            if (gångerklickad == true)
            {
                operand.Content = "Produkt";
            }
        }

        private void delat_Click(object sender, RoutedEventArgs e)
        {
            delatklickad = true;
            tal1 = Convert.ToDouble(tal1text.Text);
            tal2 = Convert.ToDouble(tal2text.Text);
            resultat = Math.Round(tal1 / tal2, 2);
            summa.Text = Convert.ToString(resultat);

            if (delatklickad == true)
            {
                operand.Content = "Differens";
            }
        }
    }
}
