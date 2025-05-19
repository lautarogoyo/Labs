// See https://aka.ms/new-console-template for more information

List<int> listaInt = new List<int>();

Console.WriteLine("Agregue numeros");
string entrada = Console.ReadLine();
listaInt = entrada.Split(' ').Select(int.Parse).ToList();

var lista = from i in listaInt where i > 20 select i;

Console.WriteLine("Los numeros mayores a 20 son: ");
foreach (var i in lista)
{
    Console.WriteLine(i);
}