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

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour ChoixSupprimer.xaml
    /// </summary>
    public partial class ChoixSupprimer : Window
    {
        public ChoixSupprimer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChoixSupprJoueur choixSupprJoueur = new ChoixSupprJoueur();
            choixSupprJoueur.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChoixSupprEquipe choixSupprEquipe = new ChoixSupprEquipe();
            choixSupprEquipe.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ChoixSupprStade choixSupprStade = new ChoixSupprStade();
            choixSupprStade.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChoixModif choixModif = new ChoixModif();
            choixModif.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ChoixListe choixlist = new ChoixListe();
            choixlist.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Postconnexion postconnexion = new Postconnexion();
            postconnexion.Show();
        }
    }
}
