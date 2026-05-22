using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        void ListarAlumnos(List<Alumno> alumnos)
        {
            foreach (Alumno a in alumnos)
            {
                Console.WriteLine(a.ToString());
            }
        }
        //Agregar 3 alumnos a la lista
        var alu1 = new Alumno(123, "Patricio Rey", 9.9);
        var alu2 = new Alumno(221, "Pappo", 8.8);
        var alu3 = new Alumno(321, "Pity Alvarez", 9.7);
        CasoList.Add(alu1);
        CasoList.Add(alu2);
        CasoList.Add(alu3);

        //Listar por consola los alumnos
        Console.WriteLine("----- Los alumnos presentes en la lista son -----\n");
        ListarAlumnos(CasoList.GetAlumnos());

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine($"\nBuscando alumno...");
        var alumnoExistente = CasoList.FindAlumno("Patricio Rey");
        Console.WriteLine($" Se encontró al alumno {alumnoExistente.ToString()} ----\n");

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine($"\nBuscando alumno...");
        var alumnoNoExistente = CasoList.FindAlumno("Cristina Fernandez");
        if (alumnoNoExistente is null) Console.WriteLine("No existe");
        else Console.WriteLine($"---- Se encontró al alumno {alumnoNoExistente.ToString()} ----");

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine($"\nEliminando alumno...");
        CasoList.RemoveAlumno(alu3);
        ListarAlumnos(CasoList.GetAlumnos());
        Console.WriteLine($"\n---- Alumno eliminado...----\n");

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine($"\nEliminando alumno en la posición indicada...");
        CasoList.RemoveAlumnoAt(0);
        ListarAlumnos(CasoList.GetAlumnos());
        Console.WriteLine($"\n---- Alumno eliminado...----\n");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        void ListarAlumnos(Dictionary<int, Alumno> alumnos)
        {
            foreach (KeyValuePair<int, Alumno> alu in alumnos)
            {
                Console.WriteLine(alu.Value.ToString());
            }
        }
        //Agregar 3 alumnos al diccionario
        var alu1 = new Alumno(123, "Patricio Rey", 9.9);
        var alu2 = new Alumno(221, "Pappo", 8.8);
        var alu3 = new Alumno(321, "Pity Alvarez", 9.7);
        CasoDictionary.Add(alu1);
        CasoDictionary.Add(alu2);
        CasoDictionary.Add(alu3);

        //Listar por consola los alumnos
        Console.WriteLine("---Alumnos en el Diccionario---\t");
        ListarAlumnos(CasoDictionary.GetAlumnos());
        Console.WriteLine("---------------------------------\n");

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("Buscando alumno...");
        var alumnoEncontrado = CasoDictionary.FindAlumno(123);
        Console.WriteLine(alumnoEncontrado?.ToString());
        Console.WriteLine("---------------------------------\n");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("Buscando alumno...");
        var alumnoNoEncontrado = CasoDictionary.FindAlumno(8);
        if (alumnoNoEncontrado == null) Console.WriteLine("No existe");
        
        else Console.WriteLine(alumnoNoEncontrado.ToString());
        
        Console.WriteLine("---------------------------------\n");

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("Eliminando alumno...");
        CasoDictionary.RemoveAlumno(123);

        Console.WriteLine("Mostrando lista actualizada...");
        ListarAlumnos(CasoDictionary.GetAlumnos());
        Console.WriteLine("---------------------------------\n");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("1.- Obtener el primer libro");
        Console.WriteLine($"Primer Libro: {CasoLinq.GetPrimero()?.ToString()}");
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("2.- Obtener el último libro");
        Console.WriteLine($"Último Libro: {CasoLinq.GetUltimo()?.ToString()}");
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("3.- Obtener la suma de los precios");
        Console.WriteLine($"Suma de precios: {CasoLinq.GetTotalPrecios()}");
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("4.- Obtener el promedio de precios");
        Console.WriteLine($"Promedio de precios es: {CasoLinq.GetPromedioPrecios():n2}");
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("5.- Obtener la lista de libros con Id mayor a 15");
        Console.WriteLine("\nLista:");
        foreach (var libro in CasoLinq.GetListById())
        {
            Console.WriteLine($"\t{libro.ToString()}");
        }
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("6.- Obtener la lista de libros en el formato especificado");
        Console.WriteLine("\nLista:");
        foreach (var libro in CasoLinq.GetLibros())
        {
            Console.WriteLine($"\t{libro}");
        }
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("7.- Obtener el libro con el precio más alto");
        Console.WriteLine($"Libro con el precio más alto: {CasoLinq.GetMayorPrecio()?.ToString()}");
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("8.- Obtener el libro con el precio más bajo");
        Console.WriteLine($"Libro con el precio más bajo: {CasoLinq.GetMenorPrecio()?.ToString()}");
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("9.- Obtener la lista de libros con un precio mayor al promedio");
        Console.WriteLine("\nLista:");
        foreach (var libro in CasoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"\t{libro.ToString()}");
        }
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("10.- Obtener la lista de libros ordenados de forma descendente");
        Console.WriteLine("\nLista:");
        foreach (var libro in CasoLinq.GetLibrosOrdenados())
        {
            Console.WriteLine($"\t{libro.ToString()}");
        }
        Console.WriteLine("---------------------------\n");
    }
}
