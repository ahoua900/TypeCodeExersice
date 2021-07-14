using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using TypeUser.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypeUser.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumListe : ContentPage
    {
        public AlbumListe()
        {
            InitializeComponent();
        }
        public async void TousLesAlbums()
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<List<Users>>(reponse).ToArray();
            Albumliste.ItemsSource = contente;
        }

        private void Albumliste_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (Albums)e.Item;
            Navigation.PushAsync(new SingleAlbum(item));
        }
    }
}