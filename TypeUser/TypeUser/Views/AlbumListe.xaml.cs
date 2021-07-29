using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using TypeUser.Models;
using Newtonsoft.Json;
using TypeUser.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypeUser.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumListe : ContentPage
    {
        public AlbumListe()
        {
            InitializeComponent();
        }        
        
    }
}