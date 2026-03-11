using System;
using System.Runtime.CompilerServices;

namespace PruebaDiagnostica.Exercises
{
    public class Palindromo
    {
        //Método para ejecutar el ejercicio
        public static void Run()
        {
            Console.WriteLine("Ingresa una palabra para verificar si es palíndroma:");
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("La entrada no puede estar vacía.");
                return;
            }
            bool isPalindrome = IsPalindrome(word);
            if (isPalindrome)
            {
                Console.WriteLine($"La palabra '{word}' es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"La palabra '{word}' no es un palíndromo.");
            }
        }

        //Método que retorna true si una palabra es palíndroma o false en caso contrario
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }

}