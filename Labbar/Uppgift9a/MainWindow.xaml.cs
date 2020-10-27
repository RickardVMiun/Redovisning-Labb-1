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

namespace Uppgift9a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int userAge;
        string användarensNamn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void kontrollknapp_Click(object sender, RoutedEventArgs e)
        {
            userAge = Convert.ToInt32(åldersbox.Text);
            if (userAge >= 15)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får se alla filmer.");
            }
            else if (userAge <= 6)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får titta på barntillåtna filmer.");
            }
            else if (userAge <= 14 && userAge >= 11)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får titta på filmer med åldersgräns upp till 11 år.");
            }
            else if (userAge >= 7 && userAge < 11)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och du får titta på filmer med åldersgräns upp till 7 år.");
            }
        }

        private void namnbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            användarensNamn = namnbox.Text;
        }
    }
}
