using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texto2Voz{
    class Program{
        static void Main(string[] args){
            Voz Sonido = new Voz("Hola Mundo");
            bool Ejecucion = Sonido.Hablar();

            Console.WriteLine("Ejecucion exitosa? {0}", Ejecucion);
            Console.ReadKey();
        }
    }
}
