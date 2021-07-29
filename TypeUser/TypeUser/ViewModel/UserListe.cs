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
    public class UserListe : BaseViewModel
    {
        public UserListe()
        {
            AllUsers = new ObservableCollection<Users>();
            AllUsersListe();
        }
        public ObservableCollection<Users> _allUsers;
        public ObservableCollection<Users> AllUsers
        {
            get { return _allUsers; }
            set
            {
                _allUsers = value;
                OnPropertyChanged();
            }
        }
        public async void AllUsersListe()
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
