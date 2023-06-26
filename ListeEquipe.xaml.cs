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
namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour ListeEquipe.xaml
    /// </summary>
    public partial class ListeEquipe : Window
    {
        public ListeEquipe()
        {
            InitializeComponent();
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await GetAllEquipes();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
