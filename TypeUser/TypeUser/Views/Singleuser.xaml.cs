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
    public partial class Singleuser : ContentPage
    {
        public Singleuser(Users users)
        {
            InitializeComponent();
            OneUser(users.Id);
        }
        public async void OneUser(int id)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/users/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Users>(reponse);
            name.Text = contente.Name;
            username.Text = contente.Username;
            phone.Text = contente.Phone;
            website.Text = contente.Website;
            city.Text = contente.Adress.City;
            street.Text = contente.Adress.Street;
           zipcode.Text = contente.Adress.Zipcode;
            email.Text = contente.Email;
            suite.Text = contente.Adress.Suite;
        }
    }
}