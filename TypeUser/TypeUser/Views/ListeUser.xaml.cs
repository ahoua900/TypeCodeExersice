using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using TypeUser.Models;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using TypeUser.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypeUser.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeUser : ContentPage
    {
        public ListeUser()
        {
            InitializeComponent();
        }
        
    }
}