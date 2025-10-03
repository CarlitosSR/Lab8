using System;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("===== Menú Central de Ejercicios =====");
                Console.WriteLine("1. Ejercicio 1: Bicola con entrada restringida");
                Console.WriteLine("2. Ejercicio 8: Insertar en bicola en posición");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                string entrada = Console.ReadLine();
                int opcion;
                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Accediendo al menú del Ejercicio 1...");
                        Ejercicio_1.Ejecutar1();
                        Console.WriteLine("Has salido del menú del Ejercicio 1.");
                        Console.WriteLine("Presione una tecla para volver al menú central...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Accediendo al menú del Ejercicio 8...");
                        Ejercicio_8.Ejecutar8();
                        Console.WriteLine("Has salido del menú del Ejercicio 8.");
                        Console.WriteLine("Presione una tecla para volver al menú central...");
                        Console.ReadKey();
                        break;
                    case 3:
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (!salir);
        }
    }
}
