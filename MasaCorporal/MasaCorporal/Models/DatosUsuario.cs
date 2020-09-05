using System;
using System.Collections.Generic;
using System.Text;

namespace MasaCorporal.Models
{
    public class DatosUsuario
    {
        private float iMC;

        public float Altura { get; set; }
        public int Peso { get; set; }
        //public float IMC
        //{
        //    get
        //    {
        //        if (Altura != 0 && Peso != 0)
        //        {
        //            return (float)(Peso / (Math.Pow(Altura, 2)));
        //        }
        //        else return 0;
        //    }

        //    set
        //    {
        //        iMC = value;
        //    }
        //}

        public float IMC { get; set; }
    }
}
