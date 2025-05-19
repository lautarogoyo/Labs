// See https://aka.ms/new-console-template for more information

string[] provincias = new string[]
{
    "Buenos Aires",
    "Catamarca",
    "Chaco",
    "Chubut",
    "Córdoba",
    "Corrientes",
    "Entre Ríos",
    "Formosa",
    "Jujuy",
    "La Pampa",
    "La Rioja",
    "Mendoza",
    "Misiones",
    "Neuquén",
    "Río Negro",
    "Salta",
    "San Juan",
    "San Luis",
    "Santa Cruz",
    "Santa Fe",
    "Santiago del Estero",
    "Tierra del Fuego",
    "Tucumán"
};

var provinciasST = (from p in provincias
                  where (p.StartsWith("S")) || (p.StartsWith("T"))
                  select p).ToArray();

Console.WriteLine("Provincias que empiezan con S o T:");
foreach (var p in provinciasST)
{
    Console.WriteLine(p);
}