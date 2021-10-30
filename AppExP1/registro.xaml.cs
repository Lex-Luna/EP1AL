using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppExP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        double cuotasCal = 0;
        string usuarioIng = "";
        public registro(string usuario)
        {
            InitializeComponent();
            txtEstudiante.Text = "Usuario Conectado: "+ usuario;
            usuarioIng = usuario;
        }

        private async void guardar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new resumen(usuarioIng,txtNombre.Text,cuotasCal));
        }

        private void calcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double adelanto = txtMonto.Text != "" ? Convert.ToDouble(txtMonto.Text) : 0;
                if (adelanto > 0) { 
                    double costo = 1800 * 1.05;
                    cuotasCal = (costo - adelanto) / 3;

                    txtMensual.Text = cuotasCal.ToString();
                }else
                {
                    DisplayAlert("Adelnato Incorrecto", "debe ingresar un valor mayor a 0", "ok");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Adelnato Incorrecto", "debe ingresar un valor mayor a 0", "ok");
            }
        }
    }
}