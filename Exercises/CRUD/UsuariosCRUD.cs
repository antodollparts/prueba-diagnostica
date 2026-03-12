namespace PruebaDiagnostica.Exercises.CRUD
{
    //Clase de lógica para el CRUD de usuarios
    public class UsuariosCRUD
    {
        private List<Usuarios> usuarios;
        private int nextId;

        public UsuariosCRUD()
        {
            usuarios = new List<Usuarios>();
            nextId = 1;
        }

        //Metodo principal para ejecutar el CRUD de usuarios
        public static void Run()
        {
            UsuariosCRUD crud = new UsuariosCRUD(); // instancia local
            bool salir = false;

            //Submenu para elegir la operación CRUD a realizar
            while (!salir)
            {
                Console.WriteLine("\n=== CRUD Usuarios ===");
                Console.WriteLine("1. Crear usuario");
                Console.WriteLine("2. Ver usuarios");
                Console.WriteLine("3. Actualizar usuario");
                Console.WriteLine("4. Eliminar usuario");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opcion: ");

                string opcion = Console.ReadLine()!;

                switch (opcion)
                {
                    case "1":
                        crud.Create();
                        crud.Read();
                        break;
                    case "2":
                        crud.Read();
                        break;
                    case "3":
                        crud.Update();
                        crud.Read();
                        break;
                    case "4":
                        crud.Delete();
                        crud.Read();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }

        public void Create()
        {
            Console.WriteLine("\n=== Crear Usuario ===");
            Console.Write("Nombre: ");
            string name = Console.ReadLine()!;
            Console.Write("Usuario: ");
            string user = Console.ReadLine()!;
            Console.Write("Edad: ");
            string age = Console.ReadLine()!;
            Console.Write("Contraseña: ");
            string password = Console.ReadLine()!;

            Usuarios newUser = new Usuarios(nextId++, name, user, age, password);
            usuarios.Add(newUser);
            Console.WriteLine("Usuario creado con ID: " + newUser.Id);
        }

        public void Read()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
                return;
            }

            Console.WriteLine("\n=== Lista de Usuarios ===");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.Id}, Name: {usuario.Name}, User: {usuario.User}, Age: {usuario.Age}");
            }
        }

        public void Update()
        {
            Console.WriteLine("\n=== Actualizar Usuario ===");
            Console.Write("ID del usuario a actualizar: ");
            int id = Convert.ToInt32(Console.ReadLine()!);
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }
            Console.WriteLine($"Actualizando usuario: {usuario.Name}");
            Console.Write("Nuevo nombre: ");
            string name = Console.ReadLine()!;
            Console.Write("Nuevo usuario: ");
            string user = Console.ReadLine()!;
            Console.Write("Nueva edad: ");
            string age = Console.ReadLine()!;
            Console.Write("Nueva contraseña: ");
            string password = Console.ReadLine()!;

            usuario.Name = name;
            usuario.User = user;
            usuario.Age = age;
            usuario.Password = password;
            Console.WriteLine("Usuario actualizado.");
        }

        public void Delete()
        {
            Console.WriteLine("\n=== Eliminar Usuario ===");
            Console.Write("ID del usuario a eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine()!);
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }

            usuarios.Remove(usuario);
            Console.WriteLine("Usuario eliminado.");
        }
    }
}