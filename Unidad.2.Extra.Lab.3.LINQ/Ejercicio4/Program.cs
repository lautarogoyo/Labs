// See https://aka.ms/new-console-template for more information

using Ejercicio4;

List<Empleado> empleados = new List<Empleado>();

Console.WriteLine("Ingrese el número de empleados:");
int numEmpleados = int.Parse(Console.ReadLine());
for (int i = 0; i < numEmpleados; i++)
{
    Empleado empleado = new Empleado();
    Console.WriteLine($"Ingrese el ID del empleado {i + 1}:");
    empleado.id = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese el nombre del empleado {i + 1}:");
    empleado.nombre = Console.ReadLine();
    Console.WriteLine($"Ingrese el sueldo del empleado {i + 1}:");
    empleado.sueldo = decimal.Parse(Console.ReadLine());
    empleados.Add(empleado);
}

var ordenAsc = empleados .OrderBy(e => e.sueldo);
foreach(var empleado in ordenAsc)
{
    Console.WriteLine($"ID: {empleado.id}, Nombre: {empleado.nombre}, Sueldo: {empleado.sueldo}");
}
var ordenDesc = empleados.OrderByDescending(e => e.sueldo);
foreach (var empleado in ordenDesc)
{
    Console.WriteLine($"ID: {empleado.id}, Nombre: {empleado.nombre}, Sueldo: {empleado.sueldo}");
}