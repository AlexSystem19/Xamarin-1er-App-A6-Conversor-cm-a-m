using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;
        public Convertir()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            lblResultado.Text = m.ToString() + "m";
        }

        private void Validar()
        {
            if(!string.IsNullOrEmpty(txtcm.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingresar Cantidad", "Continuar");
            }
        }


        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}