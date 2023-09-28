using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAbstracaoCelular
{
    internal class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Construtor da classe base é chamado com os parâmetros necessários
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um iPhone {Modelo}");
        }
    }

}
