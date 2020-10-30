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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] values = new double[5];
        int räknare = 0;

        private void restart()
        {
            Array.Clear(values, 0, values.Length);
        }


        // listlåda.Items.Add(userInput.Text);
        // userInput.Clear();
        // fungerande -- values[räknare] = listlåda.Items.Add(userInput.Text);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okknapp_Click(object sender, RoutedEventArgs e)
        {
            if (räknare < 5)
            {
                values[räknare] = Convert.ToDouble(userInput.Text);
                räknare++;

            }
            listlåda.ItemsSource = null;
            listlåda.ItemsSource = values;
            var medel = values.Sum() / values.Length;
            medelVärde.Text = Convert.ToString(medel);


            if (räknare == 5)
            {
                okknapp.IsEnabled = false;
            }
        }

        private void listlåda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void nollställ_Click(object sender, RoutedEventArgs e)
        {
            restart();
            userInput.Clear();
            medelVärde.Clear();
            listlåda.ItemsSource = null;
            räknare = 0;
            okknapp.IsEnabled = true;
            userInput.Focus();
            
        }
    }
}