using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using TypeUser.Models;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypeUser.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeUser : ContentPage
    {
        public ListeUser()
        {
            InitializeComponent();
            TousLesUsers();
        }
        public async void TousLesUsers()
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/users";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<List<Users>>(reponse).ToArray();
            Userliste.ItemsSource = contente;
        }

        private void Userliste_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (Users)e.Item;
            Navigation.PushAsync(new Singleuser(item));
        }
    }
}