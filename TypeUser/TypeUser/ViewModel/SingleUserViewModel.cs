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
        
        public Users User
        {
            get => Get<Users>();
            set => Set(value);
        }
        public SingleUserViewModel(Users users)
        {
            User = new Users();
            LoadOneUser(users.Id);
        }
        public async void LoadOneUser(int id)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/users/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Users>(reponse);
            User = contente;
        }
    }
}
