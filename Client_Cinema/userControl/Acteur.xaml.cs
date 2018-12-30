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
    /// Logique d'interaction pour Acteur.xaml
    /// </summary>
    public partial class Acteur : UserControl
    {
        public Acteur()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            titreLB.Visibility = Visibility.Visible;
            titreTBX.Visibility = Visibility.Visible;
            rechercherFilm.Visibility = Visibility.Visible;
            filmDG.Visibility = Visibility.Visible;
        }
    }
}
