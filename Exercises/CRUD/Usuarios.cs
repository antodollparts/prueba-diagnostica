namespace PruebaDiagnostica.Exercises.CRUD;
public class Usuarios
    {
        //Definición de la clase Usuarios con sus propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Age { get; set; }
        public string Password { get; set; }

        public Usuarios(int id, string name, string user, string age, string password)
        {
            Id = id;
            Name = name;
            User = user;
            Age = age;
            Password = password;
        }
    }