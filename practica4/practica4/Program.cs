/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 04/11/2014
 * Time: 07:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
namespace practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			String ruta;
			
			do {
			int opc=0;
			Console.WriteLine("presione 1 para leer archivo");
			Console.WriteLine("presione 2 para salir");
			try
            {
                using (StreamReader leer = new StreamReader(ruta, false))
                {
                	Console.WriteLine("ingrese ruta de archivo");
			Console.WriteLine("EJEMPLO: C:\\archivo.csv");
			ruta=Console.ReadLine();
                    string line;
                    while ((line = leer.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }
			}while(opc!=0);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}