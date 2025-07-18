
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
        case 3:
            EliminarLibroPorIndice();
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

bool ExisteIndice(string indice)
{
    int numeroIndice;
    try
    {
        numeroIndice = int.Parse(indice);
    } catch {
        Console.WriteLine("El indice ingresado no es un numero");
        return false;
    }

    if(numeroIndice < 0)
    {
        Console.WriteLine("El indice ingresado debe ser superior a 0");
        return false;
    }

    int cantidad = libros.Count();

    if(numeroIndice >= cantidad)
    {
        Console.WriteLine("El indice ingresado no existe");
        return false;
    }

    return true;
}

void EliminarLibroPorIndice()
{
    Console.WriteLine("Ingrese el indice del libro:");
    string indice = Console.ReadLine();

    bool existe = ExisteIndice(indice);
    if(existe)
    {
        libros.RemoveAt(int.Parse(indice));
        Console.WriteLine("Libro eliminado");
    }
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
