using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
{
        public string nombre;
        public string correo;
        public int edad;
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Escribe Tu Nombre");
            p.nombre = Console.ReadLine();
            Console.WriteLine("Escribe Tu Correo");
            p.correo = Console.ReadLine();
            Console.WriteLine("Escribe Tu Edad");
            p.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Mi Nombre Es: " + p.nombre + "\n Mi Correo Es: " + p.correo + "\n Mi Edad Es: " + p.edad + "Años");
            Console.Read();
        }
    }
}
       
    
}
