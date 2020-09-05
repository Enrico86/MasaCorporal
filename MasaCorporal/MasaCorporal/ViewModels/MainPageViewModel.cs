using MasaCorporal.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MasaCorporal.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        public DatosUsuario Datos { get; set; }
        public ICommand CalcularCommand { get; set; }

        private string resultado = "";

        public MainPageViewModel()
        {
            Datos = new DatosUsuario();
            CalcularCommand = new Command(() =>
              {
                  var imc = Math.Round(Datos.Peso / (Math.Pow(Datos.Altura, 2)),4);
                  if (imc < 18.5)
                  { resultado = "Tu indice de masa corporal es bajo peso"; }
                  else if (imc >= 18.5 && imc < 25)
                  { resultado = "Tu indice de masa corporal es normal"; }
                  else if (imc >= 25 && imc < 30)
                  { resultado = "Tu indice de masa corporal es sobrepeso"; }
                  else resultado = "Tu indice de masa corporal es obeso";
                  Datos.IMC = (float)imc;
                  App.Current.MainPage.DisplayAlert("IMC", resultado, "OK");
              });
        }
    }
}
