    List<string> nombreProductos = new List<string>();
    int sumaPrecios = 0;
    Console.WriteLine("Ingresa el la cantidad de productos que deseas llevar");
    var cantidadProductos = int.Parse(Console.ReadLine());


    for (int i = 0; i < cantidadProductos; i++)
    {
        try
        {
            Console.WriteLine($"Ingresa el nombre del producto No:{i}");
            nombreProductos.Add(Console.ReadLine());

            Console.WriteLine($"Escribe el precio del producto que Ingresaste");
            sumaPrecios = sumaPrecios + int.Parse(Console.ReadLine());

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + "Error de formato");
        }
    }

 static int aplicarDescuento() 
{ 

}
if () 
{
    aplicarDescuento();
}
