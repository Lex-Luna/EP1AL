using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppExP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void login_Clicked(object sender, EventArgs e)
        {
            string user = txtUsuario.Text != null ? txtUsuario.Text : "";
            string password = txtUsuario.Text != null ? txtPass.Text : "";

            if (validarUserYPass(user, password))
            {
                await Navigation.PushAsync(new registro(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Ingreso Fallido", "Usuario y/o contraseña incorrectos", "ok");
            }
        }

        private Boolean validarUserYPass(string user, string pass)
        {
            if (user.Equals("estudiante2021") && pass.Equals("uisrael2021"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
