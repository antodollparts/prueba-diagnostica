using PruebaDiagnostica.Exercises;

//Programa principal para ejecutar los ejercicios

int option;
Console.WriteLine("Selecciona un ejercicio:");
Console.WriteLine("1. Palíndromos");
Console.WriteLine("2. Edad Exacta");
Console.WriteLine("3. Password Generator");
Console.WriteLine("4. Fibonacci");
option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        Palindromo.Run();
        break;
    case 2:
        EdadExacta.Run();
        break;
    case 3:
        PasswordGenerator.Run();
        break;
    case 4:
        Fibonacci.Run();
        break;
    default:
        Console.WriteLine("Por favor, seleccione una opción válida.");
        break;
}