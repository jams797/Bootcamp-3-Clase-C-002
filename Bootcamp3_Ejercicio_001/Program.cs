
using Bootcamp3_Ejercicio_001;

List<Libro> libros = new List<Libro>()
{
    new Libro("Libro 1", "José", 2025),
};

int? opcionNumero = null;


while (opcionNumero != 0)
{
    Menu();

    string opcionEscogida = Console.ReadLine();

    opcionNumero = int.Parse(opcionEscogida);

    Console.Clear();

    switch (opcionNumero)
    {
        case 1:
            ListarLibros();
            break;
        case 2:
            RegistrarLibro();
            break;
        default:
            Console.WriteLine("Opcion no existe");
            break;
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Presiona una tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}



void Menu()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("========================");
    Console.WriteLine("BIENVENIDO AL SISTEMA");
    Console.WriteLine("Opciones:");
    Console.WriteLine("1) Listar Libros");
    Console.WriteLine("2) Registrar libro");
    Console.WriteLine("3) Eliminar libro por indice");
    Console.WriteLine("4) Actualizar año publicación por indice");
    Console.WriteLine("0) Salir");
    Console.WriteLine("");
    Console.WriteLine("Elige una opción");
    Console.WriteLine("========================");
    Console.WriteLine("");
    Console.WriteLine("");
}


void ListarLibros()
{
    int i = 0;
    foreach (Libro libro in libros)
    {
        Console.WriteLine($"#{i} - {libro.obtenerDescripcion()}");
        i++;
    }
}


void RegistrarLibro()
{
    Console.WriteLine("Ingresa el nombre del libro:");
    string nombreLibro = Console.ReadLine();
    Console.WriteLine("Ingresa el nombre del autor:");
    string autor = Console.ReadLine();
    Console.WriteLine("Ingresa el año de publicación");
    int anio = int.Parse(Console.ReadLine());

    Libro libro = new Libro(nombreLibro, autor, anio);
    libros.Add(libro);

    Console.WriteLine("");
    Console.WriteLine("Libro agregado");
}




// 1 Eliminar libro por su numero de indice
//     1.1 Eliminar el libro en base al indice que ingresa el usuario
//     1.2 Validar que ese indice ingresado exista
// 2 Actualizar el año de publicacion de un libro en base a su indice
//     2.1 Actualizar el año de publicación
//     2.2 Validar que ese indice ingresado exista
//     2.3 El año de publicación no exceda del 2025
//     2.4 El año de publicación no debe ser inferior a 1900
//     2.5 El año no se caiga si ingreso una letra
// 3 Controlar que no se caiga el aplicativo si ingreso una letra como opcion en el menu
