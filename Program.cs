using Laboratorio1;
using static Laboratorio1.Class1;

Class1 producto = Class1.Producto;

{
    while (true)
    {
        MostrarMenu();
        int opcion;
        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("No se acepta.");
            continue;
        }

        switch (opcion)
        {
            case 1:
                
                break;
            case 2:
                break;
            case 3:
                break;
            case 7:
                Console.WriteLine("Saliendo...");
                return;
            default:
                Console.WriteLine("No se acepta.");
                break;
        }

        Console.WriteLine("\nPresiona Enter para continuar...");
        Console.ReadLine();
    }
}

static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("Menú de Funciones:");
    Console.WriteLine("1. Solicitar nombre de producto");
    Console.WriteLine("2. Ver productos");
    Console.WriteLine("3. Salir");
    Console.Write("Selecciona una opción: ");
}


static void NombreProducto()
{
    Console.WriteLine("Ingrese el nombre del producto");
    Console.WriteLine("Ingrese el precio del producto");
}


