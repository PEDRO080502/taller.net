/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 6/09/2019
 * Time: 11:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			double base1, altura, radio, resul;
			int opcion;
			
			Console.WriteLine(" 1 - hallar area del circulo ");
			Console.WriteLine(" 2 - hallar area del rectangulo ");
			Console.WriteLine(" 3 - hallar area del triangulo");
			
			Console.WriteLine("escoja una de la siguientes opciones (1-2-3)");
			opcion = int.Parse(Console.ReadLine());
			
			
			
		    if (opcion == 1) {
				
		    Console.WriteLine("digite el radio " ); 
			radio = double.Parse(Console.ReadLine());
			
			resul = Math.PI * Math.Pow(radio,2);
			Console.WriteLine("el area del circulo es " + resul );
			
		    
			}else if (opcion == 2) {
				
				Console.WriteLine("digite la base " );
				base1 = double.Parse(Console.ReadLine());
				
				Console.WriteLine("digite la altura " );
				altura = double.Parse(Console.ReadLine());
				
				resul = altura * base1;
				
				Console.WriteLine("el area del rectangulo es " + resul );
				
			}else if (opcion == 3) {
				
				Console.WriteLine("digite la base " );
				base1 = double.Parse(Console.ReadLine());
				
				Console.WriteLine("digite la altura " );
				altura = double.Parse(Console.ReadLine());
				
				resul = base1 * Math.Pow(altura,2);
				
				Console.WriteLine("el area del triangulo es " + resul );
			}
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}