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
    public partial class SingleAlbum : ContentPage
    {
        public SingleAlbum(Albums albums)
        {
            InitializeComponent();
            OneAlbum(albums.Id);
        }
        public async void OneAlbum(int id)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Albums>(reponse);
            title.Text = contente.Title;
        }
    }
}