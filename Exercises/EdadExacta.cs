namespace PruebaDiagnostica.Exercises
{
    public class EdadExacta
    {
        //Metodo que obtiene los datos y llama al metodo para calcular la edad exacta
        public static void Run()
        {
            Console.WriteLine("\n=== Calcular Edad Exacta ===");
            Console.WriteLine("Ingresa tu día de nacimiento:");
            int birthDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu mes de nacimiento:");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu año de nacimiento:");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu hora de nacimiento:");
            int birthHour = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Now;

            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay, birthHour, 0, 0);
            DateTime currentDate = DateTime.Now;

            CalcularEdad(birthDate, currentDate);
        }

        //Método que calcula la edad exacta en años, meses, semanas, días y horas
        public static void CalcularEdad(DateTime birthDate, DateTime currentDate)
        {
            int years = currentDate.Year - birthDate.Year;
            int months = currentDate.Month - birthDate.Month;
            int days = currentDate.Day - birthDate.Day;
            int hours = currentDate.Hour - birthDate.Hour;

            // Ajustes cuando el valor es negativo
            if (hours < 0) { hours += 24; days--; }
            if (days < 0) { days += DateTime.DaysInMonth(currentDate.Year, currentDate.Month - 1); months--; }
            if (months < 0) { months += 12; years--; }

            int weeks = days / 7;
            days = days % 7;
            Console.WriteLine($"Tienes: {years} años, {months} meses, {weeks} semanas, {days} días y {hours} horas.");
        }
    }
}
