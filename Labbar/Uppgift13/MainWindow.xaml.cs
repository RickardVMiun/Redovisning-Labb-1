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

namespace Uppgift13
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string användarensMening = userInput.Text;
            int count = 0;
            char konverteradChar = Convert.ToChar(userLetter.Text);
            foreach (char c in användarensMening)
            {
                if (c == konverteradChar)
                {
                    count++;
                }
            }
            letterResult.Content = $"Det finns {count} stycken {konverteradChar} i din mening.";
        }
    }
}
