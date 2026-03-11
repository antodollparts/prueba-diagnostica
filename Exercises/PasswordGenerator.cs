namespace PruebaDiagnostica.Exercises
{
    public class PasswordGenerator
    {
        //Metodo que obtiene la longitud de la contraseña y llama al metodo para generar la contraseña
        public static void Run()
        {
            Console.WriteLine("Ingresa la longitud de la contraseña:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Por favor, ingresa un número válido para la longitud de la contraseña.");
                return;
            }
            else
            {
                int length = Convert.ToInt32(input);
                if (length < 8)
                {
                    Console.WriteLine("La longitud mínima de la contraseña debe ser de 8 caracteres.");
                    return;
                }
                string password = GeneratePassword(length);
            Console.WriteLine($"Contraseña generada: {password}");
            }
        }

        //Metodo que genera una contraseña aleatoria con letras mayúsculas, minúsculas, números y caracteres especiales
        public static string GeneratePassword(int length)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }
    }
}