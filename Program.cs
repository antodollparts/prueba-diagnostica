using PruebaDiagnostica.Exercises;

//Programa principal para ejecutar los ejercicios
int option;
Console.WriteLine("Selecciona un ejercicio:");
Console.WriteLine("1. Palíndromos");
option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        Palindromo.Run();
        break;
    default:
        Console.WriteLine("Por favor, seleccione una opción válida.");
        break;
}