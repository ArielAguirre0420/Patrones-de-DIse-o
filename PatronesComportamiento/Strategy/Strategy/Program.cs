using Strategy.Clases;
using Strategy.Interfaces;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardadoService guardadoService = new GuardadoService();

            Console.WriteLine("Ingresa el nombre de la imagen:  ");

            string cNombreImgagen = Console.ReadLine();

            string opt = imprimeMenu();

            guardadoService.SetStrategy(opt);

            guardadoService.send(cNombreImgagen);

            Console.ReadKey();
        }

        public static string imprimeMenu()
        {
            Console.WriteLine("\nEliga el número que corresponda al formato en el que desea guardar la imagen" +
                "\n1. BMP" +
                "\n2. JPGE" +
                "\n3. PNG");
            string opt = Console.ReadLine();

            return opt;
        }

    }
}
