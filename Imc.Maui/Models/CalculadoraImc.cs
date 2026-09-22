using System;
using System.Collections.Generic;
using System.Text;

namespace Imc.Maui.Models
{
    public static class CalculadoraImc
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        public static string SituacionNutricional (decimal imc)
        {
            if (imc < 18.5m)
            {
                return "peso bajo";
                    
            }
            if ( imc < 25.0m)
            {
                return "peso normal";
            }
            if (imc < 30.0m)
                {
                return "sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "obecidad";
            }
            return "obecidad extrema";

        }
    }
}
