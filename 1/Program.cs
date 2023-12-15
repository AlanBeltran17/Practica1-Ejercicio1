using _1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaObjetos
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Numeros n = new Numeros();
            n.PedirNumero();
            n.ConvertirALiteral();

            Console.ReadKey();
        }
    }
}