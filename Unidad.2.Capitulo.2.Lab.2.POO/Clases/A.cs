using System;

namespace Clases
{
    public class A
    {
        string _NombreInstancia;
        public string NombreInstancia
        {
            get { return _NombreInstancia;}
            set {  _NombreInstancia = value;}
        }
        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre) {
            NombreInstancia = nombre;
        }
        public void MostrarNombre() {
            Console.WriteLine($"El nombre de la instancia es {NombreInstancia}");
        }
        public void M1(){
            Console.WriteLine("M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("M2 fue invocado");
        }
        public void M3()
        {
            Console.WriteLine("M3 fue invocado");
        }
    }
}
