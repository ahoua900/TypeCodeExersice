using System;
using System.Collections.Generic;
using TypeUser.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace TypeUser.ViewModel
{
    public class SIngleAlbumViewModel : BaseViewModel
    {
       public SIngleAlbumViewModel(Albums albums)
        {
            OneAlbum(albums.Id);
        }
        public Albums _albums;
        public Albums Albums
        {
            get { return _albums; }
            set
            {
                _albums = value;
                OnPropertyChanged();
            }
        }
        public async void OneAlbum(int id)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Albums>(reponse);
        }
    }
}
