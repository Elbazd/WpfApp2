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
    /// Logique d'interaction pour ChoixModifStade.xaml
    /// </summary>
    public partial class ChoixModifStade : Window
    {
        public ChoixModifStade()
        {
            InitializeComponent();
        }

        private const string apiUrl = "https://localhost:7069/api/ControllerStade";
        public async Task GetAllStades()
        {
            using (HttpClient client = new HttpClient())
            {


                try
                {
                    var response = await client.GetAsync("https://localhost:7069/api/ControllerStade");
                    response.EnsureSuccessStatusCode();

                    //message.Content = await response.Content.ReadAsStringAsync();

                    String resp = await response.Content.ReadAsStringAsync();
                    List<Stades> stade = JsonConvert.DeserializeObject<List<Stades>>(resp);

                    datagrid2.ItemsSource = stade;
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
            await GetAllStades();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private async void Button_Click_2Async(object sender, RoutedEventArgs e)
        {
            string personId = Stade.Text; // Récupérer l'ID de la personne à mettre à jour depuis un TextBox ou un autre contrôle WPF
            string newName =    StadeModif.Text; // Récupérer le nouveau nom depuis un TextBox ou un autre contrôle WPF


            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"{apiUrl}/{personId}"; // Construire l'URL complète pour la ressource à mettre à jour

                    // Créer un objet contenant les nouvelles données de la personne
                    var updatedPerson = new Stades { id = "", nom_stade = newName };

                    // Convertir l'objet en JSON
                    string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(updatedPerson);

                    // Créer un contenu JSON à envoyer
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Envoyer la requête PUT à l'API
                    HttpResponseMessage response = await client.PutAsync(url, content);

                    // Vérifier si la requête a réussi
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Le stade a été mise à jour avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la mise à jour du stade.");
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
