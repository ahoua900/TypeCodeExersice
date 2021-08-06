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
        public AlbumListeViewModel()
        {          
            LoadAllAlbums();
        }
        public ObservableCollection<Albums> _allAlbums;
        public ObservableCollection<Albums> AllAlbums
        {
            get { return _allAlbums; }
            set
            {
                _allAlbums = value;
                OnPropertyChanged();
            }
        }
        //I Load all albums exist in this Api
        public async void LoadAllAlbums()
        {
            AllAlbums = new ObservableCollection<Albums>();
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<ObservableCollection<Albums>>(reponse);
            AllAlbums = contente;
        }
    }
}
