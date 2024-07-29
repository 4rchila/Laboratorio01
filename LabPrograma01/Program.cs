internal class Program
{
    private static void Main(string[] args)
    {
        List<string> nombreProductos = new List<string>();
        int sumaPrecios = 0;
        int Cantidad = 0;
        Console.WriteLine("Ingresa el la cantidad de productos que deseas llevar");
        var cantidadProductos = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidadProductos; i++)
        {
            try
            {
                Console.WriteLine($"Ingresa el nombre del producto No:{i + 1}");
                nombreProductos.Add(Console.ReadLine());

                Console.WriteLine($"Escribe el precio del producto que Ingresaste");
                sumaPrecios = sumaPrecios + int.Parse(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "Error de formato");
            }
        }

        static int aplicarDescuento(int Cantidad, int sumaPrecios)
        {
            Cantidad = (int)(sumaPrecios - (sumaPrecios * 0.40));
            return Cantidad;
        }
        if (sumaPrecios > 5000)
        {
            Console.Clear();
            Console.WriteLine("Sobre pasaste los Q5000.00, por ello se aplicara un descuento del 40% en el precio total de los productos");
            Console.WriteLine("El precio total a pagar es de:");
            Console.WriteLine(aplicarDescuento(Cantidad, sumaPrecios));
        }
        else 
        {
            Console.Clear();
            foreach (var p in nombreProductos) 
            {
                Console.WriteLine(p);
            }
            Console.WriteLine($"La cantidad a pagar por los productos es: {sumaPrecios}");

        }
    }
}