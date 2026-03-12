# Evaluación Diagnóstica

Proyecto de consola desarrollado en C# que resuelve una serie de ejercicios de lógica y algoritmos como parte de una prueba técnica. El proyecto demuestra el uso de variables, métodos, buenas prácticas de programación, código limpio y estructurado.

---

## Tecnologías

- Lenguaje: C# (.NET)
- IDE: Visual Studio / Visual Studio Code
- Control de versiones: Git + GitHub

---

## Cómo ejecutar

1. Clonar el repositorio
```bash
git clone https://github.com/antodollparts/prueba-diagnostica.git
```
2. Ingresar a la carpeta del proyecto
```bash
cd prueba-diagnostica
```
3. Ejecutar el proyecto
```bash
dotnet run
```
4. Seleccionar el ejercicio desde el menú interactivo

---

## Ejercicios

| # | Ejercicio |
|---|-----------|
| 1 | Palíndromo |
| 2 | Edad Exacta | 
| 3 | Generador de Contraseña | 
| 4 | Ahorcado | 
| 5 | Fibonacci |
| 6 | CRUD Usuarios |

---

## Estructura del proyecto

```
prueba-diagnostica/
├── Program.cs                  ← Menú principal
├── Exercises/
│   ├── Palindromos.cs          ← Verifica si una cadena es palíndromo
│   ├── Ahorcado.cs             ← Juego del ahorcado con palabra aleatoria
│   ├── PasswordGenerator.cs    ← Generador de contraseñas seguras
│   ├── EdadExacta.cs           ← Cálculo de edad exacta (años, meses, días, horas)
│   ├── Fibonacci.cs            ← Secuencia de Fibonacci
│   └── CRUD/
│       ├── Usuarios.cs         ← Modelo de usuario
│       └── UsuariosCRUD.cs     ← Gestión de usuarios (agregar, listar, editar, eliminar)
├── PruebaDiagnostica.csproj
└── PruebaDiagnostica.sln
```

---

## Autor

Desarrollado por [Antonella Junco Morán](https://github.com/antodollparts)