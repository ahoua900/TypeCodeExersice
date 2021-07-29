using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using TypeUser.Models;
using TypeUser.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypeUser.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleAlbum : ContentPage
    {       
        public SingleAlbum(Albums albums)
        {
            InitializeComponent();
            BindingContext = new SIngleAlbumViewModel(albums);
            
        }
        
    }
}