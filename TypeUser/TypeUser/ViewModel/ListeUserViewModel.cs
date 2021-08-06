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
    public class ListeUserViewModel : BaseViewModel
    {       
        public ObservableCollection<Users> AllUsers
        {
            get => Get<ObservableCollection<Users>>();
            set => Set(value);
        }
        public ListeUserViewModel()
        {
            AllUsers = new ObservableCollection<Users>();
            LoadAllUsers();
        }
        public async void LoadAllUsers()
        {         
            string ApiUrl = "https://jsonplaceholder.typicode.com/users";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<ObservableCollection<Users>>(reponse);
            AllUsers = contente;
        }
    }
}
