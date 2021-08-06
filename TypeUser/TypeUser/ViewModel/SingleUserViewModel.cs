using System;
using System.Collections.Generic;
using TypeUser.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace TypeUser.ViewModel
{
    public class SingleUserViewModel : BaseViewModel
    {
        public SingleUserViewModel(Users users)
        {
            LoadOneUser(users.Id);
        }
        public Users _users;
        public Users Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }
        public async void LoadOneUser(int id)
        {
            Users = new Users();
            string ApiUrl = "https://jsonplaceholder.typicode.com/users/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Users>(reponse);
            Users = contente;
        }
    }
}
