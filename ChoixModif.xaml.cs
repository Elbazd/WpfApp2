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
    /// Logique d'interaction pour ChoixModif.xaml
    /// </summary>
    public partial class ChoixModif : Window
    {
        public ChoixModif()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ChoixListe choixListe = new ChoixListe();
            choixListe.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Postconnexion postconnexion = new Postconnexion();
            postconnexion.Show();  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChoixSupprimer choixSupprimer = new ChoixSupprimer();
            choixSupprimer.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChoixModifJoueur choixmodifjoueur = new ChoixModifJoueur();
            choixmodifjoueur.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChoixModifEquipe choixModifEquipe = new ChoixModifEquipe();
            choixModifEquipe.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ChoixModifStade choixModifStade = new ChoixModifStade();
            choixModifStade.Show();
        }
    }
}
