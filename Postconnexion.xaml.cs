﻿using System;
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
    /// Logique d'interaction pour Postconnexion.xaml
    /// </summary>
    public partial class Postconnexion : Window
    {
        public Postconnexion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChoixCréationJoueur c = new ChoixCréationJoueur();
            c.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChoixCréationEquipe o = new ChoixCréationEquipe();
            o.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChoixListe l = new ChoixListe();
            l.Show();  
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ChoixSupprimer suppr = new ChoixSupprimer();   
            suppr.Show(); 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ChoixCréationStade s = new  ChoixCréationStade();
            s.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ChoixModif choixModif = new ChoixModif();
            choixModif.Show();
        }
    }
}
