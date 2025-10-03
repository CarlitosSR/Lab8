using Lab8.Bicolas;

namespace Lab8.Ejercicios
{
    internal class Ejercicio4
    {
        // Bicola de cadenas (simulada usando int para índices y un arreglo de strings)
        public static void Ejecutar4()
        {
            // Ejemplo de palabras
            string[] palabras = { "oso", "casa", "reconocer", "sol", "anilina", "hola" };

            // Bicola de palabras (simulada con índices)
            Bicola2 bicolaPalabras = new Bicola2();
            for (int i = 0; i < palabras.Length; i++)
                bicolaPalabras.EncolarFinal(i); // Encolamos el índice

            int numPalindromos = 0;

            while (true)
            {
                try
                {
                    int idx = bicolaPalabras.DesencolarFrente();
                    string palabra = palabras[idx];
                    if (EsPalindromo(palabra))
                        numPalindromos++;
                }
                catch
                {
                    break; // Bicola vacía
                }
            }

            Console.WriteLine($"Número de palíndromos en la bicola: {numPalindromos}");
        }

        // Verifica si una palabra es palíndromo usando bicola de caracteres
        private static bool EsPalindromo(string palabra)
        {
            Bicola2 bicolaCaracteres = new Bicola2();
            foreach (char c in palabra.ToLower())
                bicolaCaracteres.EncolarFinal(c);

            int n = palabra.Length / 2;
            for (int i = 0; i < n; i++)
            {
                int frente = bicolaCaracteres.DesencolarFrente();
                int final = bicolaCaracteres.DesencolarFinal();
                if (frente != final)
                    return false;
            }
            return true;
        }
    }
}
