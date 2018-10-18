using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defino Nombre
            string strNombre;
            // Defino Direccion
            string strDireccion;
            // Defino Codigo Postal
            int intCP;
            // Defino Ciudad
            string strCiudad;
            // Defino Provincia
            string strProvincia;
            // Defino Pais
            string strPais;
            // Defino Codigo Pais Telefono
            int intCodigoPais;
            // Defino Codigo Area Telefono
            int intCodigoArea;
            // Defino Telefono
            int intTelefono;

            // Solicito nombre
            Console.Write("Ingrese su nombre: ");
            strNombre = Console.ReadLine(); 

            // Solicito domicilio
            Console.Write("Ingrese su domicilio: ");
            strDireccion = Console.ReadLine();
            
            // Solicito codigo postal
            Console.Write("Ingrese su codigo postal: ");
            intCP = Convert.ToInt32(Console.ReadLine());
            
            // Solicito localidad
            Console.Write("Ingrese su localidad: ");
            strCiudad = Console.ReadLine();
            
            // Solicito provincia
            Console.Write("Ingrese su provincia: ");
            strProvincia = Console.ReadLine();
            
            // Solicito pais
            Console.Write("Ingrese su pais: ");
            
            // Solicito telefono combinado
            strPais = Console.ReadLine();

            Console.Write("Ingrese su Telefono (codigo pais + area + telefono): ");
            intCodigoPais = Convert.ToInt32(Console.ReadLine());
            intCodigoArea = Convert.ToInt32(Console.ReadLine());
            intTelefono = Convert.ToInt32(Console.ReadLine());

            // Ahora muestro todo lo que pedi por pantalla

            Console.WriteLine("Tu nombre es {0} y vives en {1} de la ciudad de {2} - {3} de la provincia de {4} en {5}, y tu telefono es {6}{7}{8}", strNombre, strDireccion, intCP, strCiudad, strProvincia, strPais, intCodigoPais, intCodigoArea, intTelefono);
            Console.ReadKey();

        }
    }
}
