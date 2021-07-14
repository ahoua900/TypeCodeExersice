using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TypeUser.Views;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TypeUser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}
