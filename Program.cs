static void Main(string[] args)
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