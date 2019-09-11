/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 7/09/2019
 * Time: 12:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string nombre; 
			double unidad;
			
			Console.WriteLine("digite su nombre");
			nombre = Console.ReadLine();
			
			Console.WriteLine("digite su unidad correspondiente");
			unidad = double.Parse(Console.ReadLine());
			
			if (unidad >= 0 && unidad <= 199) {
				
				Console.WriteLine( nombre + " su unidad/caraga es: 1.20");
				
			}else if (unidad >= 200 && unidad < 400) {
				
				Console.WriteLine( nombre + " su unidad/caraga es: 1.50");
				
			}else if (unidad >= 400 && unidad < 600) {
				
				Console.WriteLine( nombre + " su unidad/caraga es: 1.80");
				
			}else if (unidad >= 600) {
				
				Console.WriteLine( nombre + " su unidad/caraga es: 1.80");
				
			}else {
				
				Console.WriteLine("ERROR  numero no valido");
				
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}