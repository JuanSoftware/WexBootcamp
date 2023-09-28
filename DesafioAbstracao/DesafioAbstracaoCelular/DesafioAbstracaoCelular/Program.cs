using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAbstracaoCelular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456", "Nokia 8", "1234567890", 64);

            
            Iphone iphone = new Iphone("987654", "iPhone 12", "0987654321", 128);

            
            Console.WriteLine("Operações com o Nokia:");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\nOperações com o iPhone:");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            Console.ReadKey();
        }
    }
}
