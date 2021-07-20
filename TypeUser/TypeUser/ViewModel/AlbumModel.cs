using System;
using System.Net.Http;
using TypeUser.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;


namespace TypeUser.ViewModel
{
    public class AlbumModel
    {
        public async void TousLesAlbums(ListView Albumliste)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<List<Users>>(reponse).ToArray();
            Albumliste.ItemsSource = contente;
        }
    }
}
