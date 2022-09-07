using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSmartphone.Models
{
    internal class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            var nomeAplicativo = aplicativo.Substring(0, aplicativo.Length - 4);
            var tipoAplicativo = aplicativo.Substring(aplicativo.Length - 3);
            var temPonto = aplicativo.Substring(aplicativo.Length - 4, 1) == ".";
            if (temPonto)
            {
                if (tipoAplicativo.ToUpper() == "APK")
                {
                    Console.WriteLine($"O aplicativo {nomeAplicativo} foi instalado no Samsung");
                }
                else
                {
                    Console.WriteLine($"Não foi possivel instalar {nomeAplicativo}. O tipo de arquivo {tipoAplicativo} não é compatível com o sistema de instalação.");
                }
            }
            else
            {
                Console.WriteLine("Tipo de arquivo inválido.");
            }

        }
    }
}
