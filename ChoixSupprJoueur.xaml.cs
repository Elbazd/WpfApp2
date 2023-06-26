using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    /// Logique d'interaction pour ChoixSupprJoueur.xaml
    /// </summary>
    public partial class ChoixSupprJoueur : Window
    {
        public ChoixSupprJoueur()
        {
            InitializeComponent();
        }
        private const string apiUrl = "https://localhost:7069/api/ControllerJoueur";
        public async Task GetAllJoueurs()
        {
            using (HttpClient client = new HttpClient())
            {


                try
                {
                    var response = await client.GetAsync("https://localhost:7069/api/ControllerJoueur");
                    response.EnsureSuccessStatusCode();

                    //message.Content = await response.Content.ReadAsStringAsync();

                    String resp = await response.Content.ReadAsStringAsync();
                    List<Joueurs> joueur = JsonConvert.DeserializeObject<List<Joueurs>>(resp);

                    datagrid.ItemsSource = joueur;
                    Console.WriteLine(resp);

                }
                catch
                {
                    MessageBox.Show("error");
                }

            }

        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await GetAllJoueurs();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private async void  Button_Click_2Async(object sender, RoutedEventArgs e)
        {
            String personId = Joueur.Text; // Récupérer l'ID de la personne à supprimer depuis un TextBox ou un autre contrôle WPF

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"{apiUrl}/{personId}"; // Construire l'URL complète pour la ressource à supprimer

                    // Envoyer la requête DELETE à l'API
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    // Vérifier si la requête a réussi
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Le stade a été supprimée avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la suppression du stade.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une exception s'est produite : " + ex.Message);
            }
        }
    }

       
}
