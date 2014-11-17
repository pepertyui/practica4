using System;
using System.IO;
namespace practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			String ruta;
			int opc=0;
			
 			
			// TODO: Implement Functionality Here
			do {
			Console.WriteLine("presione 1 para leer archivo");
			Console.WriteLine("presione 2 para salir");
			opc=int.Parse(Console.ReadLine());
			if(opc!=2){
			
			try
            {
				Console.WriteLine("ingrese ruta de archivo");
			Console.WriteLine("EJEMPLO: C:\\archivo.csv");
			ruta=Console.ReadLine();
                using (StreamReader leer = new StreamReader(ruta, false))
                {
                	
                    string line;
                    while ((line = leer.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    leer.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");            
                
            }
			}
			}while(opc!=2);
 			
 			
 			
		}
	}
}