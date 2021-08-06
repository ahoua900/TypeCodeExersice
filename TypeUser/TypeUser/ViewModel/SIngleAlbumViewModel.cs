using System;
using System.Collections.Generic;
using TypeUser.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Text;

namespace TypeUser.ViewModel
{
    public class SIngleAlbumViewModel : BaseViewModel
    {
      
        public Albums Album
        {
            get => Get<Albums>();
            set => Set(value);
        }
        public SIngleAlbumViewModel(Albums albums)
        {
            Album = new Albums();
            LoadOneAlbum(albums.Id);
        }
        public async void LoadOneAlbum(int id)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Albums>(reponse);
            Album = contente;
        }
    }
}
