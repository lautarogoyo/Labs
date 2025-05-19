// See https://aka.ms/new-console-template for more information

using System.Collections;
using Ejercicio3;

ArrayList ciudades = new ArrayList();
ciudades.Add(new Ciudad { Nombre = "Rosario", CodigoPostal = "2000" });
ciudades.Add(new Ciudad { Nombre = "Buenos Aires", CodigoPostal = "1000" });
ciudades.Add(new Ciudad { Nombre = "Córdoba", CodigoPostal = "5000" });
ciudades.Add(new Ciudad { Nombre = "La Plata", CodigoPostal = "1900" });
ciudades.Add(new Ciudad { Nombre = "Mendoza", CodigoPostal = "5500" });
ciudades.Add(new Ciudad { Nombre = "Salta", CodigoPostal = "4400" });
ciudades.Add(new Ciudad { Nombre = "Tucumán", CodigoPostal = "4000" });
ciudades.Add(new Ciudad { Nombre = "Santa Fe", CodigoPostal = "3000" });
ciudades.Add(new Ciudad { Nombre = "Neuquén", CodigoPostal = "8300" });
ciudades.Add(new Ciudad { Nombre = "Chaco", CodigoPostal = "3500" });

Console.WriteLine("Ingrese expresion de 3 caracteres");
string resp = Console.ReadLine().ToLower();

var resultado = ciudades
    .OfType<Ciudad>()
    .Where(c => c.Nombre.ToLower().Contains(resp))
    .Select(c => new { c.Nombre, c.CodigoPostal });

foreach(var codigo in resultado)
{
    Console.WriteLine(codigo.CodigoPostal);
}