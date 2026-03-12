using PruebaDiagnostica.Exercises;
using PruebaDiagnostica.Exercises.CRUD;

//Programa principal para elegir los ejercicios a ejecutar

Console.WriteLine("=== Ejercicios ===");
Console.WriteLine("1. Palindromos");
Console.WriteLine("2. Edad Exacta");
Console.WriteLine("3. Generador de Contraseñas");
Console.WriteLine("4. Ahorcado");
Console.WriteLine("5. Fibonacci");
Console.WriteLine("6. CRUD Usuarios");
Console.WriteLine("Ingrese el número del ejercicio:");

int option = Convert.ToInt32(Console.ReadLine());
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
        Ahorcado.Run();
        break;
    case 5:
        Fibonacci.Run();
        break;
    case 6:
        UsuariosCRUD.Run();
        break;
    default:
        Console.WriteLine("Por favor, seleccione una opción válida.");
        break;
}