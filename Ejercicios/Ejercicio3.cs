using Lab8.Bicolas;

namespace Lab8.Ejercicios
{
    internal class Ejercicio3
    {
        public static void Ejecutar3()
        {
            Console.Write("Ingrese una palabra para verificar si es palíndromo: ");
            string palabra = Console.ReadLine();

            Bicola bicola = new Bicola();

            // Encolar cada carácter por el final
            foreach (char c in palabra)
            {
                bicola.EncolarFinal(c);
            }

            bool esPalindromo = true;
            int n = palabra.Length / 2;

            for (int i = 0; i < n; i++)
            {
                int frente = bicola.DesencolarFrente();
                int final = bicola.DesencolarFinal();

                if (frente != final)
                {
                    esPalindromo = false;
                    break;
                }
            }

            if (esPalindromo)
                Console.WriteLine($"La palabra \"{palabra}\" es un palíndromo.");
            else
                Console.WriteLine($"La palabra \"{palabra}\" NO es un palíndromo.");
        }
    }
}
