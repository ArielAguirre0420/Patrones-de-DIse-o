using Command.Clases;
using System;
using System.Threading;

namespace Command
{
    public class Program
    {
        static bool lHabilidadExtra1 = false;
        static bool lHabilidadExtra2 = false;
        static string menuPrincipal = "Estas son las acciones que puede realizar el guerrero\n" +
                                "1. Caminar\n" +
                                "2. Saltar\n" +
                                "3. Golpear\n" +
                                "4. Disparar Pistola\n";
        static string OpExtraMenu1 = "5. Conseguir Lanzagranadas\n";
        static string OpExtraMenu2 = "6. Conseguir Rifle de Plasma\n";

        static void Main(string[] args)
        {
            try
            {
                Iniciar();
            }
            catch (Exception e)
            {
                imprimir(e.Message);
            }

            Console.ReadKey();
        }

        public static void Iniciar()
        {
            int optMenuGuerreros = MenuGuerreros();

            imprimir("Ingrese su nombre");
            string cNombrePersonaje = leerNombre();

            int optMenuPrincipal = MenuPrincipal();

            Client client = new Client();
            client.RealizarAccion(optMenuGuerreros, optMenuPrincipal, cNombrePersonaje);
        }

        public static int MenuPrincipal()
        {
            string optextramenu1 = "5. Lanzar Granada\n";
            string optextramenu2 = "6. Disparar Rifle de Plasma\n";
            string menuTemporal = "";

            if (lHabilidadExtra1 && lHabilidadExtra2 == false)
            {
                menuTemporal = menuPrincipal + optextramenu1 + OpExtraMenu2;
            }

            if (lHabilidadExtra2 && lHabilidadExtra1 == false)
            {
                menuTemporal = menuPrincipal + OpExtraMenu1 + optextramenu2;
            }

            if (lHabilidadExtra1 && lHabilidadExtra2)
            {
                menuTemporal = menuPrincipal + optextramenu1 + optextramenu2;
            }

            if (lHabilidadExtra1 == false && lHabilidadExtra2 == false)
            {
                menuTemporal = menuPrincipal + OpExtraMenu1 + OpExtraMenu2;
            }

            imprimir(menuTemporal);
            return ObtenerOpcionMenurincipal();
        }

        public static int ObtenerOpcionMenurincipal()
        {
            int opt = leerNum();

            if (opt == 5 && lHabilidadExtra1 == false)
            {
                lHabilidadExtra1 = true;
                reimprimirMenuAcciones("lanzar Granadas");
            }

            if (opt == 6 && lHabilidadExtra2 == false)
            {
                lHabilidadExtra2 = true;
                reimprimirMenuAcciones("disparar con el Rifle de Plasma");
            }

            if (opt > 6 || opt <= 0)
            {
                imprimir("Solo se permite ingresar los valores del menú");
                MenuPrincipal();
            }

            return opt;
        }

        public static int MenuGuerreros()
        {
            int opt = 0;
            string menu = "Seleccione al guerrero\n" +
                            "1. Guerrero de Clase Baja, con poder de 10\n" +
                            "2. Guerrero de Clase Baja, con poder de 20\n" +
                            "3. Guerrero de Clase Baja, con poder de 30";
            imprimir(menu);

            try
            {
                opt = leerNum();

                if (opt > 3 || opt < 0)
                {
                    imprimir("Debe proporcionar una de las opciones del menu");
                    MenuGuerreros();
                }
            }
            catch (Exception e)
            {
                imprimir(e.Message);
                MenuGuerreros();
            }

            return opt;
        }

        public static void reimprimirMenuAcciones(string mensaje)
        {
            imprimir($"\n el arma {mensaje} ya puede ser utilizada por el guerrero \n");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal();
        }

        private static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        private static string leerNombre()
        {
            return Console.ReadLine();
        }

        private static int leerNum()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("El valor no es un entero");
            }
        }
    }
}
