using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberSemana31
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contrasena = txtcontrasena.Text;
            if (usuario=="estudiante2021" && contrasena=="uisrael2021") {
                await Navigation.PushAsync(new Principal(usuario, contrasena));
            }
            else
            {
                await DisplayAlert("ERROR", "Credenciales Incorrectas", "Aceptar");

            }
            
        }
    }
}