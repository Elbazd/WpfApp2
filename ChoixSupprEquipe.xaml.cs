using Newtonsoft.Json;
using System;
using System.Collections;
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
    /// Logique d'interaction pour ChoixSupprEquipe.xaml
    /// </summary>
    public partial class ChoixSupprEquipe : Window
    {
        public ChoixSupprEquipe()
        {
            InitializeComponent();
        }

        private const string apiUrl = "https://localhost:7069/api/ControllerEquipe";
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public async Task GetAllEquipes()
        {
            using (HttpClient client = new HttpClient())
            {

                    
                try
                {
                    var response = await client.GetAsync("https://localhost:7069/api/ControllerEquipe");
                    response.EnsureSuccessStatusCode();

                    //message.Content = await response.Content.ReadAsStringAsync();

                    String resp = await response.Content.ReadAsStringAsync();
                    List<Equipes> equipe = JsonConvert.DeserializeObject<List<Equipes>>(resp);

                    datagrid1.ItemsSource = equipe;
                    Console.WriteLine(resp);

                }
                catch
                {
                    MessageBox.Show("error");
                }

            }

        }

        private async void Button_Click1(object sender, RoutedEventArgs e)
        {
            await GetAllEquipes();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private async void Button_Click_2Async(object sender, RoutedEventArgs e)
        {
            String personId = Equipe.Text; // Récupérer l'ID de la personne à supprimer depuis un TextBox ou un autre contrôle WPF

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
                        MessageBox.Show("L'équipe a été supprimée avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la suppression de l'équipe.");
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
