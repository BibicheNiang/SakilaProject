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
using Client_Cinema.ServiceReference1;

namespace Client_Cinema
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Gif_UC gif = new Gif_UC();
            //this.AddChild(gif);
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTBX.Text;
            string mdp = motdepasseTBX.Password.ToString();
           

            if(username.Equals("") || mdp.Equals(""))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }else if(username.Equals("admin") && mdp.Equals("admin"))
            {
                Principal principal = new Principal();
                principal.Show();
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Vous etes un utilisateur simple");

            }
        }
    }
}
