// See https://aka.ms/new-console-template for more information

int cantIteraciones = 5;
string[] array = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    array[i] = Console.ReadLine();
}

for (int i = cantIteraciones - 1 ; i >= 0; i--)
{
    Console.WriteLine($"Posicion: {i}");
    Console.WriteLine(array[i]);
}