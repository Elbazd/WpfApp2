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
    /// Logique d'interaction pour ChoixListe.xaml
    /// </summary>
    public partial class ChoixListe : Window
    {
        public ChoixListe()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChoixModif choixModif = new ChoixModif();
            choixModif.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ChoixSupprimer choixSupprimer = new ChoixSupprimer();
            choixSupprimer.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ListeStade liste = new ListeStade();    
            liste.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListeEquipe equipe = new ListeEquipe(); 
            equipe.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Listejoueur joueur = new Listejoueur();
            joueur.Show(); 
        
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Postconnexion cnx = new Postconnexion();
            cnx.Show();
        }
    }
}
