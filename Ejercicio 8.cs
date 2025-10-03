using System;

namespace Lab8
{
    internal class Ejercicio_8
    {
        public static void Ejecutar8()
        {
            Bicola bicola = new Bicola();
            int opcion;
            bool salir = false;

            do
            {
                Console.WriteLine("----- Menú Bicola: Insertar en posición -----");
                Console.WriteLine("1. Encolar por el frente");
                Console.WriteLine("2. Mostrar bicola");
                Console.WriteLine("3. Insertar elemento en posición");
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
                        EncolarFrente(bicola);
                        break;
                    case 2:
                        MostrarBicola(bicola);
                        break;
                    case 3:
                        InsertarElementoEnPosicion(bicola);
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

        private static void EncolarFrente(Bicola bicola)
        {
            Console.Write("Ingrese el valor a encolar por el frente: ");
            string valorStr = Console.ReadLine();
            int valor;
            if (int.TryParse(valorStr, out valor))
            {
                bicola.EncolarFrente(valor);
                Console.WriteLine("Valor encolado por el frente correctamente.\n");
            }
            else
            {
                Console.WriteLine("Valor inválido.\n");
            }
        }

        private static void MostrarBicola(Bicola bicola)
        {
            Nodo actual = bicola.getFrente();
            Console.Write("Bicola: ");
            while (actual != null)
            {
                Console.Write(actual.dato + " ");
                actual = actual.sgte;
            }
            Console.WriteLine();
        }

        private static void InsertarElementoEnPosicion(Bicola bicola)
        {
            Console.Write("Ingrese el valor a insertar: ");
            string nuevoValorStr = Console.ReadLine();
            int nuevoValor;
            if (!int.TryParse(nuevoValorStr, out nuevoValor))
            {
                Console.WriteLine("Valor inválido.\n");
                return;
            }
            Console.Write("Ingrese la posición donde insertar (0 = frente): ");
            string posicionStr = Console.ReadLine();
            int posicion;
            if (!int.TryParse(posicionStr, out posicion) || posicion < 0)
            {
                Console.WriteLine("Posición inválida.\n");
                return;
            }
            InsertarEnPosicion(bicola, nuevoValor, posicion);
            Console.WriteLine("Elemento insertado correctamente.\n");
        }

        // Inserta un elemento en la posición indicada usando solo EncolarFrente y DesencolarFinal
        private static void InsertarEnPosicion(Bicola bicola, int valor, int posicion)
        {
            var temp = new System.Collections.Generic.List<int>();
            Nodo actual = bicola.getFrente();
            int longitud = 0;
            while (actual != null)
            {
                longitud++;
                actual = actual.sgte;
            }

            for (int i = 0; i < longitud; i++)
            {
                temp.Add(bicola.DesencolarFinal());
            }

            for (int i = temp.Count - 1; i >= 0; i--)
            {
                if (i == posicion)
                {
                    bicola.EncolarFrente(valor);
                }
                bicola.EncolarFrente(temp[i]);
            }

            if (posicion >= temp.Count)
            {
                bicola.EncolarFrente(valor);
            }
        }
    }
}
