using Client_Cinema.userControl;
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
using System.Windows.Shapes;

namespace Client_Cinema
{
    /// <summary>
    /// Logique d'interaction pour Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
           //  WindowState = WindowState.Maximized;
            //WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            //CenterWindowOnScreen();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            //GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            Client client = new Client();
            Utilisateur user = new Utilisateur();
            Location location = new Location();
            Acteur acteur = new Acteur();
            Film film = new Film();
            Store store = new Store();

            switch (index)
            {
                case 0:
                    GridMain.Children.Clear();
                    
                    break;
                case 1:

                    GridMain.Children.Clear();
                    GridMain.Children.Add(user);

                    break;
                case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(client);
                    
                    break;
                case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(location);
                    break;
                case 4:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(film);
                    break;

                case 5:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(acteur);
                    break;

                case 6:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(store);
                    break;

            }
        }
        /*private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }*/
    }
}
