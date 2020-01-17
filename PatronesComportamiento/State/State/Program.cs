using State.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var EstadoInicial = new Activada();
            var context = new Alarma(EstadoInicial);
            EstadoInicial.SetContext(context);



            Console.WriteLine("--Activando alarma--");
            context.Activar();
            Console.ReadKey();
            Console.WriteLine("--Desactivando alarma--");
            context.Desactivar();
            Console.ReadKey();
            Console.WriteLine("--Desactivando alarma--");
            context.Desactivar();
            Console.ReadKey();
            Console.WriteLine("--Activando alarma--");
            context.Activar();

            Console.ReadKey();
        }
    }
}
