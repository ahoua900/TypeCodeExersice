using System;
using System.Net.Http;
using TypeUser.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms; 
using System.Text;

namespace TypeUser.ViewModel
{
    public class UserListe
    {
        public async void TousLesUsers(ListView Userliste)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/users";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<List<Users>>(reponse).ToArray();
            Userliste.ItemsSource = contente;
        }
    }
}
