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
using Newtonsoft.Json;
using System.Net;
using System.Xml.Linq;


namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour ChoixCréationStade.xaml
    /// </summary>
    public partial class ChoixCréationStade : Window
    {
        public ChoixCréationStade()
        {
            InitializeComponent();
        }


        private const string apiUrl = "https://localhost:7069/api/ControllerStade";


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Créer un objet contenant les données à envoyer à l'API
                        string insertname = Stade.Text;

                        var data = new Stades { id = "", nom_stade = insertname };

                        // Convertir l'objet en JSON
                        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                        // Créer un contenu JSON à envoyer
                        var content = new StringContent(jsonData, Encoding.Default, "application/json");

                        // Envoyer la requête POST à l'API
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                        // Vérifier si la requête a réussi
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Données envoyées avec succès !" + jsonData);

                        }
                        else
                        {
                            MessageBox.Show("Une erreur s'est produite lors de l'envoi des données."+jsonData);
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

    
    

