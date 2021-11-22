using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SignaturePad.Forms;
using System.IO;

namespace firma
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }
       

        private async void btnlista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Listafirma());
        }

        private async void save_Clicked(object sender,EventArgs e)
        {
            var image = await PadView.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Png);
            var mStream = (MemoryStream)image;
            byte[] data = mStream.ToArray();
            string base64Val = Convert.ToBase64String(data);
           

            try
            {
                var firmas = new Models.firma
                {

                    name = this.txtnombre.Text,
                    descripcion = this.txtdescrip.Text,
                   
                    MiImagen = data

                };

                var resultado = await App.Basedatos.GrabarFirma(firmas);


                if (resultado == 1)
                {
                    await DisplayAlert("Mensaje", "Ingresada Exitosamente", "OK");
                }
                else
                {
                    await DisplayAlert("Mensaje", "Error, No se logro guardar Ubicacion", "OK");

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje", ex.Message.ToString(), "OK");

            }
        }
        private  void clear_Clicked(object sender, EventArgs e)
        {
            PadView.Clear();
        }
    }
}
