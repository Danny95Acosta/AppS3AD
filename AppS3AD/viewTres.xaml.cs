using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3AD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewTres : ContentPage
    {
        public viewTres()
        {
            InitializeComponent();
        }
        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            try
            {

                //Almacenar en variable lo que el usuario ingrese en la aja de texto
                double datoUno = Convert.ToDouble(txtDatoUno.Text);
                double datoDos = Convert.ToDouble(txtDatoDos.Text);

                // vaiable parcial dos 
                double datoTres = Convert.ToDouble(txtDatoTres.Text);
                double datoCuatro = Convert.ToDouble(txtDatoCuatro.Text);

                //Operacion de parcial uno
                double muti = datoUno * 0.3;
                double exa = datoDos * 0.2;
                double suma = muti + exa;
                // Operacion de parcial dos 
                double mult = datoTres * 0.3;
                double examen = datoCuatro * 0.2;
                double sum = mult + examen;
                double fin = suma + sum;

                // operacion de parcial dos 


                //convertir para string pra visualizar en un Enttry
                txtResultao.Text = Convert.ToString(suma);
                txtParcial.Text = Convert.ToString(sum);
                txtFinal.Text = Convert.ToString(fin);
            }


            catch (Exception ex)
            {

                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");

            }

        }

        private void txtDatoUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtDatoUno.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos Mayores a 10", "OK");
                    // txtDatoUno.Text = "";
                }
            }
            catch (Exception ex)
            {
                //  DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtDatoTres_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtDatoTres.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos Mayores a 10", "OK");
                    // txtDatoUno.Text = "";
                }
            }
            catch (Exception ex)
            {
                //  DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtDatoDos.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos Mayores a 10", "OK");
                    // txtDatoUno.Text = "";
                }
            }
            catch (Exception ex)
            {
                //  DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtDatoCuatro_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtDatoCuatro.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos Mayores a 10", "OK");
                    // txtDatoUno.Text = "";
                }
            }
            catch (Exception ex)
            {
                //  DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtFinal_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtFinal.Text);
                if (dato <= 6.9)
                {
                    DisplayAlert("Mensaje de Alerta", "COMPLEMENTARIO", "OK");
                    // txtDatoUno.Text = "";


                }

                else
                    if (dato <= 4.9)
                {
                    DisplayAlert("Mensaje de Alerta", "REPROBADO", "OK");
                }
                else

                if (dato <= 10)
                {
                    DisplayAlert("Mensaje de Alerta", "APROBADO", "OK");
                }


            }
            catch (Exception ex)
            {

                //  DisplayAlert("Alerta", ex.Message, "OK");
            }

        }
    }
}