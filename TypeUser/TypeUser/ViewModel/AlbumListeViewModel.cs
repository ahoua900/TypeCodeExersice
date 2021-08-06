using System;
using System.Net.Http;
using TypeUser.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Text;

namespace TypeUser.ViewModel
{
    public class AlbumListeViewModel : BaseViewModel
    {        
        public ObservableCollection<Albums> AllAlbums
        {
            get => Get<ObservableCollection<Albums>>();
            set => Set(value);
        }
        public AlbumListeViewModel()
        {
            AllAlbums = new ObservableCollection<Albums>();
            LoadAllAlbums();
        }
        //I Load all albums exist in this Api
        public async void LoadAllAlbums()
        {
            
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<ObservableCollection<Albums>>(reponse);
            AllAlbums = contente;
        }
    }
}
