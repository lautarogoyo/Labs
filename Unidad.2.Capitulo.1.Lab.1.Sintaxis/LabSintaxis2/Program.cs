// See https://aka.ms/new-console-template for more information

string inputTexto = Console.ReadLine();
if (inputTexto == null)
{
    Console.WriteLine("No ingreso nada");
}
else {
    Console.WriteLine("1. Mostrar en mayuscula");
    Console.WriteLine("2. Mostrar en minuscula");
    Console.WriteLine("3. Mostrar cantidad de caracteres");
    ConsoleKeyInfo opcion = Console.ReadKey();
    Console.WriteLine();
    if (opcion.KeyChar == '1')
    {
        Console.WriteLine(inputTexto.ToUpper());
    }
    else if (opcion.KeyChar == '2')
    {
        Console.WriteLine(inputTexto.ToLower());
    }
    else if (opcion.KeyChar == '3')
    {
        Console.WriteLine(inputTexto.Length);
    }
    else {
        Console.WriteLine("No eligio ninguna opcion");
    }
}