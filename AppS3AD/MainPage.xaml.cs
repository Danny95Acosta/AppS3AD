using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS3AD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btAbrir_Clicked(object sender, EventArgs e)
        {
            // Alacenar los datos en variable
            string susuario = txtUsuario.Text;
            string scontraseña = txtContraseña.Text;
            if ((susuario == "estudiante2021")&&(scontraseña == "uisrael2021"))
            {
                await Navigation.PushAsync(new viewTres());
            }
            else
            {
                lblResultado.Text = "El usuario o la contraseña son incorrectos!";
            }
            //Navegando ventana 2
          //  await Navigation.PushAsync(new viewDos(usuario, contraseña));

        }

    }
}
