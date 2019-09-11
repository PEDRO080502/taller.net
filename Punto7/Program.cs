/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 7/09/2019
 * Time: 12:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto7
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double num1, num2, num3;
			
			Console.WriteLine("ingrese un numero");
			num1 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("ingrese segundo numero");
			num2 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("ingrese tercer numero");
			num3 = double.Parse(Console.ReadLine());
			
			if (num1 > num2 && num1 > num3) {
				
				Console.WriteLine("el numero mayor es: " + num1);
				
			} else if (num2 > num1 && num2 > num3 ) {
				
				Console.WriteLine("el numero mayor es: " + num2);
				
			} else {
				
				Console.WriteLine("el numero mayor es: " + num3);
				
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}