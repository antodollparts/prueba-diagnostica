namespace PruebaDiagnostica.Exercises
{
    public class Fibonacci
    {
        //Metodo que obtiene el número de términos y llama al metodo para calcular la secuencia de Fibonacci y los imprime
        public static void Run()
        {
            Console.WriteLine("Ingresa el número de términos de la secuencia de Fibonacci:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La secuencia de Fibonacci es:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(CalcularFibonacci(i) + " ");
            }
        }

        //Método que realiza el calculo de Fibonacci de manera recursiva
        public static int CalcularFibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }
}