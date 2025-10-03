using Lab8.Bicolas;

namespace Lab8.Ejercicios
{
    internal class Ejercicio_1
    {
        public static void Ejecutar1()
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
                Console.WriteLine("----- Menú Bicola (Entrada Restringida) -----");
                Console.WriteLine("1. Encolar (solo por el final)");
                Console.WriteLine("2. Desencolar por el frente");
                Console.WriteLine("3. Desencolar por el final");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out opcion))
                {
                    Console.Clear();
                    Console.WriteLine("Opción inválida. Intente de nuevo.\n");
                    continue;
                }

                Console.Clear(); // Limpia la consola antes de ejecutar la opción

                switch (opcion)
                {
                    case 1:
                        EncolarFinal(bicola);
                        break;
                    case 2:
                        DesencolarFrente(bicola);
                        break;
                    case 3:
                        DesencolarFinal(bicola);
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
            Console.Write("Ingrese el valor a encolar: ");
            string valorStr = Console.ReadLine();
            int valor;
            if (int.TryParse(valorStr, out valor))
            {
                bicola.EncolarFinal(valor);
                Console.WriteLine("Valor encolado correctamente.\n");
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

        private static void DesencolarFinal(Bicola bicola)
        {
            try
            {
                int desencolado = bicola.DesencolarFinal();
                Console.WriteLine($"Valor desencolado por el final: {desencolado}\n");
            }
            catch (Exception)
            {
                Console.WriteLine("La bicola está vacía. No se puede desencolar.\n");
            }
        }
    }
}
