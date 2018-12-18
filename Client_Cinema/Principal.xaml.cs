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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            //GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            Client client = new Client();

            switch (index)
            {
                case 0:
                    GridMain.Background = Brushes.Aquamarine;
                    break;
                case 1:
                  
                    GridMain.Children.Add(client);
                    break;
                case 2:
                    GridMain.Background = Brushes.CadetBlue;
                    break;
                case 3:
                    GridMain.Background = Brushes.DarkBlue;
                    break;
                case 4:
                    GridMain.Background = Brushes.Firebrick;
                    break;
               
            }
        }
    }
}
