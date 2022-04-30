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
    public partial class Principal : ContentPage
    {
        private string usuario;
        private string contrasena;

        public Principal()
        {
           
        }

        public Principal(string usuario, string contrasena)
        { 

            InitializeComponent();
            this.usuario=usuario;
            this.contrasena=contrasena;
            this.txtBienvenida.Text= "Bienvenido: "+usuario;
           
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double txtseguimiento1value = Double.Parse(txtseguimiento1.Text);

            double txtexamenvalue = Double.Parse(txtExamen.Text);

            txtNotaParcial1.Text=  (txtseguimiento1value*0.3 + txtexamenvalue*0.2).ToString();


            double txtseguimiento2Value = Double.Parse(txtseguimiento2.Text);

            double txtExamenFValue = Double.Parse(txtExamenF.Text);

            txtNotaParcial2.Text=  (txtseguimiento2Value*0.3 + txtExamenFValue*0.2).ToString();


            notaFinal.Text= (Double.Parse(txtNotaParcial2.Text)+ Double.Parse(txtNotaParcial1.Text)).ToString();



            if (Double.Parse(notaFinal.Text)>=7.0)
            {
                DisplayAlert("Mensaje", "Aprobado", "Aceptar");

            }
            else if (Double.Parse(notaFinal.Text)>=5 && Double.Parse(notaFinal.Text)<=6.9)
            {
                DisplayAlert("Mensaje", "Complementario", "Aceptar");

            }
            else if (Double.Parse(notaFinal.Text)<5)
            {
                DisplayAlert("Mensaje", "Reprobado", "Aceptar");

            }
        }
    }
}