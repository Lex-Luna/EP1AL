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
    public partial class resumen : ContentPage
    {
        public resumen(string usuario, string nombre, double cuota)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtPagar.Text = cuota.ToString();
        }
    }
}