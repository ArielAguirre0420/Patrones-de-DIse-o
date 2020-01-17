using Observer.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new AzureObservado();

            var observerA = new Compilar();
            subject.addObsevador(observerA);

            var observerB = new PruebasUnitarias();
            subject.addObsevador(observerB);

            var observerC = new InstalarVersion();
            subject.addObsevador(observerC);

            var observerD = new EnviarCorreo();
            subject.addObsevador(observerD);

           

            subject.SubirCambios();

            Console.ReadKey();
        }
    }
}
