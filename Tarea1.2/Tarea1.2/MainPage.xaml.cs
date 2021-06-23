using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1._2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void enviar_Clicked(object sender, EventArgs e)
        {
            var persona = new Informacion
            {
                Nombre = this.txtnombre.Text,
                Apellido = this.txtapellido.Text,
                Edad = Convert.ToInt32(this.txtedad.Text),
                Correo = this.txtcorreo.Text

            };

            if (String.IsNullOrWhiteSpace(txtnombre.Text))
            {
                await DisplayAlert("Advertencia", "Asegurese de llenar los campos obligatorios", "OK");

            }
            else if (String.IsNullOrWhiteSpace(txtapellido.Text))
            {
                await DisplayAlert("Advertencia", "Asegurese de llenar los campos obligatorios", "OK");

            }
            else if (String.IsNullOrWhiteSpace(txtedad.Text))
            {
                await DisplayAlert("Advertencia", "Asegurese de llenar los campos obligatorios", "OK");

            }
            else if (String.IsNullOrWhiteSpace(txtcorreo.Text))
            {
                await DisplayAlert("Advertencia", "Asegurese de llenar los campos obligatorios", "OK");

            }
            else
            {
                var secondPage = new Datos();
                secondPage.BindingContext = persona;
                await Navigation.PushAsync(secondPage);
            }
        }

    }
}
