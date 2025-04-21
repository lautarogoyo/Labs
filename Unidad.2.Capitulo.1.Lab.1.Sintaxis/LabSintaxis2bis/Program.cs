// See https://aka.ms/new-console-template for more information
string inputTexto = Console.ReadLine();
if (inputTexto == null)
{
    Console.WriteLine("No ingreso nada");
}
else
{
    Console.WriteLine("1. Mostrar en mayuscula");
    Console.WriteLine("2. Mostrar en minuscula");
    Console.WriteLine("3. Mostrar cantidad de caracteres");
    ConsoleKeyInfo opcion = Console.ReadKey();
    Console.WriteLine();
    switch (opcion.KeyChar)
    {
        case '1':
            Console.WriteLine(inputTexto.ToUpper());
            break;
        case '2':
            Console.WriteLine(inputTexto.ToLower());
            break;
        case '3':
            Console.WriteLine(inputTexto.Length);
            break;
        default:
            Console.WriteLine("No eligio ninguna opcion");
            break;
    }
}