using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<float> precios = new List<float>();
        float umbralDescuento = 100.0f; 
        float porcentajeDescuento = 0.10f; 

        while (true)
        {
            string nombreProducto;
            float precioProducto;

            Console.Write("Ingrese el nombre del producto (o 'salir' para finalizar): ");
            nombreProducto = Console.ReadLine();
            if (nombreProducto.ToLower() == "salir")
                break;

            Console.Write("Ingrese el precio del producto: ");
            if (float.TryParse(Console.ReadLine(), out precioProducto) && precioProducto >= 0)
            {
                precios.Add(precioProducto);
            }
            else
            {
                Console.WriteLine("No es valido, intente de nuevo.");
            }
        }


        float totalCompra = CalcularTotal(precios);
        if (totalCompra > umbralDescuento)
        {
            totalCompra = AplicarDescuento(totalCompra, porcentajeDescuento);
            Console.WriteLine($"Descuento aplicado. Total con descuento: {totalCompra:C}");
        }
        else
        {
            Console.WriteLine($"Total de la compra: {totalCompra:C}");
        }
    }
