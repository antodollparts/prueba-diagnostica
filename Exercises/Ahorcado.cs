namespace PruebaDiagnostica.Exercises
{
    public class Ahorcado
    {
        private string word;
        private char[] lettersGuessed;
        private int remainingAttempts;
        private List<char> lettersUsed;

        private static readonly string[] words = {
            "computadora", "programacion", "algoritmo", "variable", "funcion",
            "compilador", "interfaz", "desarrollo", "software", "hardware"
        };

        public Ahorcado(string word, int remainingAttempts)
        {
            this.word = word.ToLower();
            this.lettersGuessed = new char[word.Length];
            for (int i = 0; i < lettersGuessed.Length; i++)
                lettersGuessed[i] = '_';
            this.remainingAttempts = remainingAttempts;
            this.lettersUsed = new List<char>();
        }

        //Metodo principal para ejecutar el juego del ahorcado
        public static void Run()
        {
            Console.WriteLine("\n=== Ahorcado ===");

            string givenWord = ObtenerPalabraAleatoria();
            Ahorcado game = new Ahorcado(givenWord, 5);

            while (!game.TerminarJuego())
            {
                game.MostrarEstado();
                Console.Write("Ingresa una letra: ");
                string input = Console.ReadLine()!;

                if (string.IsNullOrEmpty(input) || input.Length > 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Entrada invalida. Ingresa una sola letra.");
                    continue;
                }

                char letra = input[0];

                if (game.LetraYaUsada(letra))
                {
                    Console.WriteLine("Ya ingresaste esa letra, intenta con otra.");
                    continue;
                }

                game.RegistrarLetra(letra);
                bool acierto = game.AdivinarLetra(letra);
                Console.WriteLine(acierto ? "Correcto!" : "Incorrecto!");
            }

            game.MostrarEstado();

            if (game.Ganar())
                Console.WriteLine("Ganaste! La palabra era: " + game.word);
            else
                Console.WriteLine("Perdiste. La palabra era: " + game.word);
        }
        public bool AdivinarLetra(char letra)
        {
            letra = char.ToLower(letra);
            bool success = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letra)
                {
                    lettersGuessed[i] = letra;
                    success = true;
                }
            }
            if (!success) remainingAttempts--;
            return success;
        }

        public bool TerminarJuego()
        {
            return remainingAttempts <= 0 || new string(lettersGuessed) == word;
        }

        public bool Ganar()
        {
            return new string(lettersGuessed) == word;
        }

        public bool LetraYaUsada(char letra)
        {
            return lettersUsed.Contains(char.ToLower(letra));
        }

        public void RegistrarLetra(char letra)
        {
            lettersUsed.Add(char.ToLower(letra));
        }

        public void MostrarEstado()
        {
            Console.WriteLine("\nPalabra: " + string.Join(" ", lettersGuessed));
            Console.WriteLine("Intentos restantes: " + remainingAttempts + "/5");
            Console.WriteLine("Letras usadas: " + string.Join(", ", lettersUsed));
        }

        private static string ObtenerPalabraAleatoria()
        {
            Random random = new Random(); //Crear instancia de Random para generar una palabra aleatoria
            return words[random.Next(words.Length)];
        }
        
    }
}