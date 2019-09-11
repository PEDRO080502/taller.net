/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 7/09/2019
 * Time: 12:12 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			char car;
			
			Console.WriteLine("digite un caracter");
			car = char.Parse(Console.ReadLine().ToUpper());
			
			if (car == 'A' || car == 'E' || car == 'I' || car == 'O' || car == 'U') {
				
				Console.WriteLine("Es vocal");
				
			} else if (car == 'B' || car == 'C' || car == 'D' || car == 'F' || car == 'G' || car == 'H' || car == 'J' || car == 'K' || car == 'M'|| car == 'Ñ' || car == 'N' || car == 'P' || car == 'Q' || car == 'R' || car == 'S' || car == 'T' || car == 'V' || car == 'W' || car == 'X' || car == 'Y' || car == 'Z') {
				
				Console.WriteLine("Es consonante");
				
			}else {
				
				Console.WriteLine("el caracter que digito es un simbolo o un numero");
			}
		
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}