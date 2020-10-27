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

namespace Uppgift9b
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
            if (Convert.ToBoolean(medvuxen.IsChecked) && userAge >= 15)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får se alla filmer oavsett om du går med en vuxen.");
            }
            else if (Convert.ToBoolean(utanvuxen.IsChecked) && userAge >= 15)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får se alla filmer oavsett om du går med en vuxen eller ej.");
            }
            else if (Convert.ToBoolean(medvuxen.IsChecked) && userAge <= 6)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får titta på barntillåtna filmer, du får även titta på filmer med 7-årsgräns eftersom du har en vuxen med dig.");
            }
            else if (Convert.ToBoolean(utanvuxen.IsChecked) && userAge <= 6)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får titta på barntillåtna filmer.");
            }
            else if (Convert.ToBoolean(medvuxen.IsChecked) && userAge <= 14 && userAge >= 11)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får titta på filmer med åldersgräns upp till 11 år oavsett vuxet sällskap.");
            }
            else if (Convert.ToBoolean(utanvuxen.IsChecked) && userAge <= 14 && userAge >= 11)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och får titta på filmer med åldersgräns upp till 11 år oavsett vuxet sällskap eller ej.");
            }
            else if (Convert.ToBoolean(utanvuxen.IsChecked) && userAge >= 7 && userAge < 11)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och du får titta på filmer med åldersgräns upp till 7 år.");
            }
            else if (Convert.ToBoolean(medvuxen.IsChecked) && userAge >= 7 && userAge < 11)
            {
                ålderstext.Text = ($"Hej {användarensNamn}, du är {userAge} och du får titta på filmer med åldersgräns upp till 11 år eftersom du har en vuxen med dig.");
            }
        }

        private void namnbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            användarensNamn = namnbox.Text;
        }

        private void medvuxen_Checked(object sender, RoutedEventArgs e)
        {
        
        }

        private void utanvuxen_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}