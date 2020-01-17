using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion s1 = Conexion.GetInstance();
            Conexion s2 = Conexion.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("La conexión Singleton funciona, ambas variables contienen la misma instancia.");
            }
            else
            {
                Console.WriteLine("La conexión Singleton falló, las variables contienen diferentes instancias.");
            }

            Console.ReadKey();
        }
    }
}
