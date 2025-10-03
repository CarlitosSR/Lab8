using Lab8.Bicolas;
using Lab8.Nodos;

namespace Lab8.Ejercicios
{
    internal class Ejercicio2
    {
        public static void Ejecutar2()
        {
            Bicola bicola = new Bicola();
            EjecutarMenu(bicola);
        }

        private static void EjecutarMenu(Bicola bicola)
        {
            int opcion;
            bool salir = false;

            do
            {
                Console.WriteLine("----- Menú Bicola (Salida Restringida) -----");
                Console.WriteLine("1. Encolar por el final");
                Console.WriteLine("2. Encolar por el frente");
                Console.WriteLine("3. Desencolar por el frente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out opcion))
                {
                    Console.Clear();
                    Console.WriteLine("Opción inválida. Intente de nuevo.\n");
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        EncolarFinal(bicola);
                        break;
                    case 2:
                        EncolarFrente(bicola);
                        break;
                    case 3:
                        DesencolarFrente(bicola);
                        break;
                    case 4:
                        salir = true;
                        Console.WriteLine("Saliendo del ejercicio...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.\n");
                        break;
                }
            } while (!salir);
        }

        private static void EncolarFinal(Bicola bicola)
        {
            Console.Write("Ingrese el valor a encolar por el final: ");
            string valorStr = Console.ReadLine();
            int valor;
            if (int.TryParse(valorStr, out valor))
            {
                bicola.EncolarFinal(valor);
                Console.WriteLine("Valor encolado correctamente por el final.\n");
            }
            else
            {
                Console.WriteLine("Valor inválido.\n");
            }
        }

        private static void EncolarFrente(Bicola bicola)
        {
            Console.Write("Ingrese el valor a encolar por el frente: ");
            string valorStr = Console.ReadLine();
            int valor;
            if (int.TryParse(valorStr, out valor))
            {
                bicola.EncolarFrente(valor);
                Console.WriteLine("Valor encolado correctamente por el frente.\n");
            }
            else
            {
                Console.WriteLine("Valor inválido.\n");
            }
        }
        private static void DesencolarFrente(Bicola bicola)
        {
            try
            {
                int desencolado = bicola.DesencolarFrente();
                Console.WriteLine($"Valor desencolado por el frente: {desencolado}\n");
            }
            catch (Exception)
            {
                Console.WriteLine("La bicola está vacía. No se puede desencolar.\n");
            }
        }
    }
}