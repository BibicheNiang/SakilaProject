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

namespace Client_Cinema.userControl
{
    /// <summary>
    /// Logique d'interaction pour Film.xaml
    /// </summary>
    public partial class Film : UserControl
    {
        public Film()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nomLB.Visibility = Visibility.Visible;
            nomTBX.Visibility = Visibility.Visible;
            prenomLB.Visibility = Visibility.Visible;
            prenomTBX.Visibility = Visibility.Visible;
            rechercheracteur.Visibility = Visibility.Visible;
            acteurDG.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            libelleLB.Visibility = Visibility.Visible;
            libelleTBX.Visibility = Visibility.Visible;
            rechercherCategorie.Visibility = Visibility.Visible;
            categorieDG.Visibility = Visibility.Visible;
        }
    }
}
