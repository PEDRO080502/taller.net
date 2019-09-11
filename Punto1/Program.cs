/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 6/09/2019
 * Time: 11:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			double resul, num1, num2, opcion;
			
			
			Console.WriteLine("las opciones son:");
			Console.WriteLine(" 1 - adicion  ");
			Console.WriteLine(" 2 - sutraccion ");
			Console.WriteLine(" 3 - multiplicacion ");
			Console.WriteLine(" 4 - division ");
			
			Console.WriteLine("digite una opcion (1 - 2 - 3 - 4 )");
			opcion = int.Parse(Console.ReadLine());
			
			Console.WriteLine("digite un numero");
			num1 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("digite el segundo numero");
			num2 = double.Parse(Console.ReadLine());
			
			
			
			if (opcion == 1) {
				
		     
		    resul = num1 + num2;
			Console.WriteLine("la suma de los numeros que digito es: " + resul );
			
		    
			}else if (opcion == 2) {
				
				resul = num1 - num2;
				
				Console.WriteLine("la resta de los numeros que digito es:  " + resul );
			
				
			}else if (opcion == 3) {
				
				
				resul = num1 * num2;
				
				Console.WriteLine("la multiplicacion de los numeros que digito es: " + resul );
				
			}else if (opcion == 4) {
				
				resul = num1 / num2;
				
				
			}
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}